using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace NicolashaDolbaeb.Algorithms.SelectionSort
{
    internal class SelectionSort
    {
        public static int[] Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIxdex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIxdex])
                        minIxdex = j;
                }
                (arr[minIxdex], arr[i]) = (arr[i], arr[minIxdex]);
            }

            return arr;
        }
    }
}
