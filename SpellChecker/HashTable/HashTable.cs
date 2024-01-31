using SpellChecker.HashTable.interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpellChecker.HashTable
{
    public class HashTable<K,V>: IHashTable<K, V> where K : IComparable<K>
    {

        private readonly List<Stored<K, V>>[] hashtable;

        public HashTable(int size)
        {

            hashtable = new List<Stored<K, V>>[size];

            for (int i = 0; i < size; i++)
            {
                hashtable[i] = new List<Stored<K, V>>();
            }
        }


        public List<string> SugestiiCorectii(string cuvantGresit)
        {
            List<string> sugestii = new List<string>();

            int cheie = (int)cuvantGresit[0];

            for (int i = 0; i < hashtable[cheie].Count; i++)
            {
                string cuvantDictionar = hashtable[cheie][i].Value.ToString();

                double jaccardSimilarity = CalculeazaJaccardSimilarity(cuvantGresit, cuvantDictionar);
                if (jaccardSimilarity > 0.7)
                {
                    sugestii.Add(cuvantDictionar);
                }

            }

            sugestii.Sort((x, y) => x.Length.CompareTo(y.Length));

            sugestii = sugestii.Take(3).ToList();
            return sugestii;
        }

        private double CalculeazaJaccardSimilarity(string s1, string s2)
        {
            var set1 = new HashSet<char>(s1);
            var set2 = new HashSet<char>(s2);

            var intersection = new HashSet<char>(set1);
            intersection.IntersectWith(set2);

            var union = new HashSet<char>(set1);
            union.UnionWith(set2);

            double jaccardSimilarity = (double)intersection.Count / union.Count;
            return jaccardSimilarity;
        }

        public List<string> verificareOrtografica(List<string> cuvinte)
        {
            List<string>cuvinteGresite = new List<string>();
            if (cuvinte.Count > 0)
            {
              
                for (int i = 0; i < cuvinte.Count; i++)
                {
                    if (cuvinte[i].Length >= 1)
                    {
                        int ok = 0;
                        int nr = cuvinte[i].ToLower().Trim()[0];
                        foreach (var item in hashtable[nr])
                        {
                            if (item.Value.ToString().Equals(cuvinte[i].ToLower().Trim()))
                            {
                                ok = 1;
                                break;
                            }
                        }

                        if (ok == 0)
                        {
                            cuvinteGresite.Add(cuvinte[i]);
                        }
                    }
                   
                }



            }

            return cuvinteGresite;
        }

        private int HashKey(K key)
        {
            return int.Parse(key.ToString()) % hashtable.Length;
        }

        public void Put(K key, V value)
        {

            int hashkey = HashKey(key);
            var entry = new Stored<K, V>(key, value);

            hashtable[hashkey].Add(entry);
        }

        public V Get(K key)
        {

            int hashedKey = HashKey(key);
            foreach (var entry in hashtable[hashedKey])
            {
                if (entry.Key.Equals(key))
                {
                    return entry.Value;
                }
            }
            return default(V);
        }

        public bool Remove(K key)
        {
            int hashedKey = HashKey(key);
            var bucket = hashtable[hashedKey];
            var itemToRemove = bucket.Find(entry => entry.Key.Equals(key));

            if (itemToRemove != null)
            {
                return bucket.Remove(itemToRemove);
            }

            return false;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < hashtable.Length; i++)
            {
                sb.AppendLine($"{i}:");
                foreach (var entry in hashtable[i])
                {
                    sb.AppendLine($"-->{entry.Value}");
                }
            }
            return sb.ToString();
        }
    }
}
