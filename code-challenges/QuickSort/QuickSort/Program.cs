using System;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [2, 3, 1, 6, 4];
            int[]result =  Quicksort[arr, 0, 4];
            Console.WriteLine(result);

        }

        public static int[] Quicksort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);
                Quicksort(arr, left, position - 1);
                Quicksort(arr, position + 1, right);

            }

            return arr;

        }

        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left - 1;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] == pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }

            }
            Swap(arr, right, low + 1);
            return low + 1;
        }
        public static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }

    }
}
