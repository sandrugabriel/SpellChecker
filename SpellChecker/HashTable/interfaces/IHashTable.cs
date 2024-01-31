using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellChecker.HashTable.interfaces
{
    public interface IHashTable<K, V>
    {

        void Put(K key, V value);

        V Get(K key);

        List<string> SugestiiCorectii(string cuvantGresit);

        bool Remove(K key);

        string ToString();

        List<string> verificareOrtografica(List<string> cuvinte);


    }
}
