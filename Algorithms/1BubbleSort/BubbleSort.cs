namespace NicolashaDolbaeb.Algorithms.BubbleSort
{
    public static class BubbleSort
    {
        public static int[] SortBubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int boof = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = boof;
                    }
                }
            }
            return arr;
        }

    }
}