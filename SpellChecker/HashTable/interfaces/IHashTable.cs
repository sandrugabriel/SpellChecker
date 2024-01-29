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

        void citireFisier();

        bool Remove(K key);

        string ToString();

        void verificareOrtografica();

        void sugesti();

    }
}
