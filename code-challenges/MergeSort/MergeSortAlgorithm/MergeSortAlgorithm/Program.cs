using System;

namespace MergeSortAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Split array into subarrays and merges them back into their parent array sorted
        /// </summary>
        /// <param name="arr"> the integer array</param>
        /// <returns> sorted array </returns>
        public static int[] Mergesort(int[] arr)
        {
            int n = arr.Length;

            if (n > 1)
            {
                int mid = n / 2;
                int[] left = new int[mid];
                int[] right;

                if (arr.Length % 2 == 0)
                {
                    right = new int[mid];
                }
                else
                {
                    right = new int[mid + 1];
                }

                for (int i = 0; i < mid; i++)
                {
                    left[i] = arr[i];
                }

                int x = 0;
                for (int i = mid; i < arr.Length; i++)
                {
                    right[x] = arr[i];
                    x++;
                }

                Mergesort(left);

                Mergesort(right);

                Merge(left, right, arr);
            }

            return arr;
        }

        /// <summary>
        /// Merges the left and right side back into the parent array
        /// </summary>
        /// <param name="left">left side of the array</param>
        /// <param name="right">right side of the array</param>
        /// <param name="arr"> parent array</param>
       public  static void Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }

                k++;
            }

            if (i == left.Length)
            {
                while (j < right.Length)
                {
                    arr[k] = right[j];
                    j++;
                    k++;
                }
            }
            else
            {
                while (i < left.Length)
                {
                    arr[k] = left[i];
                    i++;
                    k++;
                }
            }
        }
    }
}
