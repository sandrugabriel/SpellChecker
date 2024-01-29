using SpellChecker.HashTable.interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpellChecker.HashTable
{
    internal class HashTable<K,V>: IHashTable<K, V> where K : IComparable<K>
    {

        private readonly List<Stored<K, V>>[] hashtable;
        private List<string> cuvinte;
        private List<string> cuvinteGresite;


        public HashTable(int size)
        {

            hashtable = new List<Stored<K, V>>[size];

            for (int i = 0; i < size; i++)
            {
                hashtable[i] = new List<Stored<K, V>>();
            }
        }

        public void citireFisier()
        {
            cuvinte = new List<string>();
            string path = @"\Mycode\CSHARP\Teorie\StructuriDeDate\StructuriDeDate\bin\Debug\data\text.txt";

            StreamReader streamReader = new StreamReader(path);


            string t = "";
            string text = "";
            while ((t = streamReader.ReadLine()) != null)
            {
                text += t;
                for (int i = 0; i < t.Split(' ').Length; i++)
                {
                    cuvinte.Add(t.Split(' ')[i]);
                }
            }

            Console.WriteLine("TEXT:\n" + text);
            streamReader.Close();

            for (int i = 0; i < cuvinte.Count; i++)
            {
                cuvinte[i] = cuvinte[i].ToLower();


                for (int k = 0; k < cuvinte[i].Length; k++)
                {
                    if ((cuvinte[i][k] >= 33 && cuvinte[i][k] <= 47) || (cuvinte[i][k] >= 58 && cuvinte[i][k] <= 64))
                    {
                        cuvinte[i] = cuvinte[i].Remove(k);
                    }
                }
            }
        }

        public void verificareOrtografica()
        {
            cuvinteGresite = new List<string>();
            Console.Write("\nIncorrect words: ");
            if (cuvinte.Count > 0)
            {

                for (int i = 0; i < cuvinte.Count; i++)
                {
                    int ok = 0;
                    int nr = cuvinte[i][0];
                    // Console.WriteLine("AA"+nr+"AA");
                    foreach (var item in hashtable[nr])
                    {
                        if (item.Value.ToString().Equals(cuvinte[i]))
                        {
                            ok = 1;
                        }
                    }

                    if (ok == 0)
                    {
                        Console.Write(cuvinte[i] + ",");
                        cuvinteGresite.Add(cuvinte[i]);
                    }
                }



            }


        }

        public void sugesti()
        {
            //cuvintele gresite:
            //cghecker,reatds,inrto,fgrom,ine,
            //sugestii la:
            //cghecker este checker
            //reatds este reads
            //inrto este into
            //fgrom este from
            //ine este in


            for (int i = 0; i < cuvinteGresite.Count; i++)
            {
                Console.WriteLine($"Suggestions for the word {cuvinteGresite[i]}:");
                string pattern = $"/{cuvinteGresite[i][cuvinteGresite[i].Length - 1]}$/";
                MatchCollection matches = Regex.Matches(cuvinteGresite[i], pattern);

                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Groups[1].Value);
                }

            }


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
