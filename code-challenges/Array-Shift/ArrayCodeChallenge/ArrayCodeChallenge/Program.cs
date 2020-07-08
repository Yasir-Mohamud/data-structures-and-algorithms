using System;

namespace ArrayCodeChallenge
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        /// <summary>
        /// takes in array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int[] InsertArrayShift(int[] arr , int number)
        {
            int arrIndex = (arr.Length + 1) / 2;
            int[] newArr = new int[arr.Length + 1];
            newArr[arrIndex] = number;
            return newArr;
        }
    }
}
