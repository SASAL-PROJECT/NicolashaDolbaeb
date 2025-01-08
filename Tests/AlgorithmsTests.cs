using System;
using Xunit;
using NicolashaDolbaeb.Algorithms.BubbleSort;
using NicolashaDolbaeb.Algorithms.InsertionSort;
using NicolashaDolbaeb.Algorithms.SelectionSort;
using NicolashaDolbaeb.Algorithms.ShakerSort;
using NicolashaDolbaeb.Algorithms.ShellSort;
using NicolashaDolbaeb.Algorithms.QuickSort;
using NicolashaDolbaeb.Algorithms.ExternalMergeSort;
using NicolashaDolbaeb.Algorithms.BinaryTreeSort;
using NicolashaDolbaeb.Algorithms.RadixSort;
using NicolashaDolbaeb.Algorithms.BinarySearch;
using NicolashaDolbaeb.Algorithms.HashTableChaining;
using NicolashaDolbaeb.Algorithms.HashTableOpenAddressing;
using NicolashaDolbaeb.Algorithms.Stack;
using NicolashaDolbaeb.Algorithms.Queue;
using NicolashaDolbaeb.Algorithms.Common;

namespace NicolashaDolbaeb.Algorithms.Tests
{
    public class AlgorithmsTests
    {
        [Theory]
        [MemberData(nameof(GetInputData))]
        public void TestBubbleSort(int[] data)
        {
            int[] expected = (int[])data.Clone();
            Array.Sort(expected);
            var actual = BubbleSort.BubbleSort.SortBubbleSort(data);
            Assert.Equal(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.True(expected[i] == actual[i], $"BubbleSort: Ошибка на индексе {i}");
            }
        }

        [Theory]
        [MemberData(nameof(GetInputData))]
        public void TestInsertionSort(int[] data)
        {
            int[] expected = (int[])data.Clone();
            Array.Sort(expected);
            var actual = InsertionSort.InsertionSort.Sort(data);
            Assert.Equal(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.True(expected[i] == actual[i], $"InsertionSort: Ошибка на индексе {i}");
            }
        }

        [Theory]
        [MemberData(nameof(GetInputData))]
        public void TestSelectionSort(int[] data)
        {
            int[] expected = (int[])data.Clone();
            Array.Sort(expected);
            var actual = SelectionSort.SelectionSort.Sort(data);
            Assert.Equal(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.True(expected[i] == actual[i], $"SelectionSort: Ошибка на индексе {i}");
            }
        }

        [Theory]
        [MemberData(nameof(GetInputData))]
        public void TestShakerSort(int[] data)
        {
            int[] expected = (int[])data.Clone();
            Array.Sort(expected);
            var actual = ShakerSort.ShakerSort.Sort(data);
            Assert.Equal(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.True(expected[i] == actual[i], $"ShakerSort: Ошибка на индексе {i}");
            }
        }

        [Theory]
        [MemberData(nameof(GetInputData))]
        public void TestShellSort(int[] data)
        {
            int[] expected = (int[])data.Clone();
            Array.Sort(expected);
            var actual = ShellSort.ShellSort.Sort(data);
            Assert.Equal(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.True(expected[i] == actual[i], $"ShellSort: Ошибка на индексе {i}");
            }
        }

        [Theory]
        [MemberData(nameof(GetInputData))]
        public void TestQuickSort(int[] data)
        {
            int[] expected = (int[])data.Clone();
            Array.Sort(expected);
            var actual = QuickSort.QuickSort.Sort(data);
            Assert.Equal(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.True(expected[i] == actual[i], $"QuickSort: Ошибка на индексе {i}");
            }
        }

        [Theory]
        [MemberData(nameof(GetInputData))]
        public void TestExternalMergeSort(int[] data)
        {
            int[] expected = (int[])data.Clone();
            Array.Sort(expected);
            var actual = ExternalMergeSort.ExternalMergeSort.Sort(data);
            Assert.Equal(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.True(expected[i] == actual[i], $"ExternalMergeSort: Ошибка на индексе {i}");
            }
        }

        [Theory]
        [MemberData(nameof(GetInputData))]
        public void TestBinaryTreeSort(int[] data)
        {
            int[] expected = (int[])data.Clone();
            Array.Sort(expected);
            var actual = BinaryTreeSort.BinaryTreeSort.Sort(data);
            Assert.Equal(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.True(expected[i] == actual[i], $"BinaryTreeSort: Ошибка на индексе {i}");
            }
        }

        [Theory]
        [MemberData(nameof(GetInputData))]
        public void TestRadixSort(int[] data)
        {
            int[] expected = (int[])data.Clone();
            Array.Sort(expected);
            var actual = RadixSort.RadixSort.Sort(data);
            Assert.Equal(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.True(expected[i] == actual[i], $"RadixSort: Ошибка на индексе {i}");
            }
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 7, 9 }, 5, 2)]
        [InlineData(new int[] { 2, 4, 6, 8, 10 }, 6, 2)] // Исправлено: индекс 6 должен быть 2
        [InlineData(new int[] { 10, 20, 30, 40, 50 }, 30, 2)]
        public void TestBinarySearch(int[] data, int target, int expectedIndex)
        {
            var actualIndex = BinarySearch.BinarySearch.Search(data, target);
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 10, 20, 30, 40, 50 })]
        [InlineData(new int[] { 5, 15, 25, 35, 45 })]
        public void TestHashTableChaining(int[] data)
        {
            var hashTable = new HashTableChaining.HashTableChaining();
            foreach (var item in data)
            {
                hashTable.Insert(item);
            }
            foreach (var item in data)
            {
                var actual = hashTable.Search(item);
                Assert.True(actual.HasValue);
            }
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 10, 20, 30, 40, 50 })]
        [InlineData(new int[] { 5, 15, 25, 35, 45 })]
        public void TestHashTableOpenAddressing(int[] data)
        {
            var hashTable = new HashTableOpenAddressing.HashTableOpenAddressing();
            foreach (var item in data)
            {
                hashTable.Insert(item);
            }
            foreach (var item in data)
            {
                var actual = hashTable.Search(item);
                Assert.True(actual.HasValue);
            }
        }

        [Fact]
        public void TestStack()
        {
            var stack = new Stack.Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.Equal(3, stack.Pop());
            Assert.Equal(2, stack.Pop());
            Assert.Equal(1, stack.Pop());
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Fact]
        public void TestQueue()
        {
            var queue = new Queue.Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.Equal(1, queue.Dequeue());
            Assert.Equal(2, queue.Dequeue());
            Assert.Equal(3, queue.Dequeue());
            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        }

        public static TheoryData<int[]> GetInputData()
        {
            var data = new TheoryData<int[]>();
            foreach (var input in InputData.GetInputData())
            {
                data.Add(input);
            }
            return data;
        }
    }
}