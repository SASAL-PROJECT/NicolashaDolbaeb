using NicolashaDolbaeb.Algorithms.HashTableChaining;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace NicolashaDolbaeb.Algorithms.HashTableChaining
{
    public class HashTableChaining
    {
        public void Insert(int key)
        {
           
        }

        public int? Search(int key)
        {
            return default(int?);
        }
    }
}


















































































//private readonly List<LinkedList<int>> _table;
//private const int Size = 10;

//public HashTableChaining()
//{
//    _table = new List<LinkedList<int>>(Size);
//    for (int i = 0; i < Size; i++)
//    {
//        _table.Add(new LinkedList<int>());
//    }
//}

//public void Insert(int key)
//{
//    int hash = key % Size;
//    _table[hash].AddLast(key);
//}

//public int? Search(int key)
//{
//    int hash = key % Size;
//    foreach (var item in _table[hash])
//    {
//        if (item == key)
//        {
//            return item;
//        }
//    }
//    return null;
//}