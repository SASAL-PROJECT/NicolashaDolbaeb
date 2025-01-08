using System;
using System.Drawing;

namespace NicolashaDolbaeb.Algorithms.HashTableOpenAddressing
{
    public class HashTableOpenAddressing
    {
        public void Insert(int key)
        {
            
        }

        public int? Search(int key)
        {

            return -1;
        }
    }
}





























































































        //private readonly int[] _table;
        //private const int Size = 10;

        //public HashTableOpenAddressing()
        //{
        //    _table = new int[Size];
        //}

        //public void Insert(int key)
        //{
        //    int hash = key % Size;
        //    while (_table[hash] != 0)
        //    {
        //        hash = (hash + 1) % Size;
        //    }
        //    _table[hash] = key;
        //}

        //public int? Search(int key)
        //{
        //    int hash = key % Size;
        //    int startHash = hash;
        //    while (_table[hash] != key)
        //    {
        //        hash = (hash + 1) % Size;
        //        if (hash == startHash)
        //        {
        //            return null;
        //        }
        //    }
        //    return _table[hash];
        //}