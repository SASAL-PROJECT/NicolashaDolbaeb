using NicolashaDolbaeb.Algorithms.Tests;
using System.IO;

namespace NicolashaDolbaeb
{
    class Program
    {
         void Main(string[] args)
        {
            if (File.Exists("Tests\\AlgorithmsTests.cs"))
            {
                System.Console.WriteLine("Файл тестов найден.");
                var tests = new AlgorithmsTests();
                var inputData = AlgorithmsTests.GetInputData();

                foreach (var dataRow in inputData)
                {
                    tests.TestBubbleSort((int[])dataRow[0]);
                    tests.TestInsertionSort((int[])dataRow[0]);
                    tests.TestSelectionSort((int[])dataRow[0]);
                    tests.TestShakerSort((int[])dataRow[0]);
                    tests.TestShellSort((int[])dataRow[0]);
                    tests.TestQuickSort((int[])dataRow[0]);
                    tests.TestExternalMergeSort((int[])dataRow[0]);
                    tests.TestBinaryTreeSort((int[])dataRow[0]);
                    tests.TestRadixSort((int[])dataRow[0]);
                }

                System.Console.WriteLine("Все тесты пройдены успешно!");
            }
            else
            {
                System.Console.WriteLine("Файл тестов не найден.");
            }
        }
    }
}
