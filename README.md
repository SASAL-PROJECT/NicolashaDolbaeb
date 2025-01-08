# Алгоритмы и структуры данных

Этот проект содержит реализации различных алгоритмов сортировки, поиска и структур данных.

## Содержание

- [Установка](#установка)
- [Запуск тестов](#запуск-тестов)
- [Использование алгоритмов](#использование-алгоритмов)
- [Структура проекта](#структура-проекта)
- [Лицензия](#лицензия)
- [Контакты](#контакты)

## Установка

### Через командную строку

1. Клонируйте репозиторий:
    ```sh
    git clone https://github.com/yourusername/your-repo.git
    cd your-repo
    ```

2. Установите зависимости:
    ```sh
    dotnet restore
    ```

3. Установите зависимости для тестов:
    ```sh
    dotnet add package xunit --version 2.4.1
    dotnet add package xunit.runner.visualstudio --version 2.4.3
    dotnet add package Microsoft.NET.Test.Sdk --version 16.9.4
    ```

### Через Visual Studio

1. Откройте Visual Studio.
2. Выберите `Clone a repository` из стартового окна или через меню `File -> Clone Repository`.
3. Введите URL репозитория (например, `https://github.com/yourusername/your-repo.git`) и выберите локальную директорию для клонирования.
4. После клонирования репозитория откройте решение (`.sln` файл).
5. Visual Studio автоматически восстановит зависимости проекта.
6. Для установки зависимостей для тестов, откройте `Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution`.
7. В появившемся окне выберите вкладку `Browse` и найдите следующие пакеты:
    - `xunit`
    - `xunit.runner.visualstudio`
    - `Microsoft.NET.Test.Sdk`
8. Установите найденные пакеты.

## Запуск тестов

### Через командную строку

Для запуска тестов используйте команду:
```sh
dotnet test
Через Visual Studio
В Visual Studio откройте Test Explorer через меню Test -> Test Explorer.
В Test Explorer нажмите Run All, чтобы запустить все тесты.


Использование алгоритмов
Вы можете использовать реализованные алгоритмы в вашем коде. Вот пример использования алгоритма сортировки пузырьком:


using NicolashaDolbaeb.Algorithms.BubbleSort;

class Program
{
    static void Main()
    {
        int[] data = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
        int[] sortedData = BubbleSort.SortBubbleSort(data);
        Console.WriteLine(string.Join(", ", sortedData));
    }
}
Структура проекта
Проект организован следующим образом:


/NicolashaDolbaeb
│
├─ /Algorithms
│  ├─ /BubbleSort
│  │  └─ BubbleSort.cs
│  ├─ /InsertionSort
│  │  └─ InsertionSort.cs
│  ├─ /SelectionSort
│  │  └─ SelectionSort.cs
│  ├─ /ShakerSort
│  │  └─ ShakerSort.cs
│  ├─ /ShellSort
│  │  └─ ShellSort.cs
│  ├─ /QuickSort
│  │  └─ QuickSort.cs
│  ├─ /ExternalMergeSort
│  │  └─ ExternalMergeSort.cs
│  ├─ /BinaryTreeSort
│  │  └─ BinaryTreeSort.cs
│  ├─ /RadixSort
│  │  └─ RadixSort.cs
│  ├─ /BinarySearch
│  │  └─ BinarySearch.cs
│  ├─ /HashTableChaining
│  │  └─ HashTableChaining.cs
│  ├─ /HashTableOpenAddressing
│  │  └─ HashTableOpenAddressing.cs
│  ├─ /Stack
│  │  └─ Stack.cs
│  ├─ /Queue
│  │  └─ Queue.cs
│  └─ /Common
│     └─ InputData.cs
│
├─ /Tests
│  └─ AlgorithmsTests.cs
│
├─ NicolashaDolbaeb.sln
├─ README.md
