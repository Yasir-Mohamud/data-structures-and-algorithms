using System;

namespace InsertionSort
{
   public class Program
    {
        static void Main(string[] args)
        {
            
        }


        public static int[] Insertionsort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                 int temp = arr[i];

             while (j >= 0 && temp < arr[j])
             {
                 arr[j + 1] = arr[j];
                 j = j - 1;
             }

             arr[j + 1] = temp;
            }

             return arr;
        }




    }


}
