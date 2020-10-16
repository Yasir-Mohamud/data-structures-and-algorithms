using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

      // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
     //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //You can return the answer in any order.

        public int[] TwoSumMethod(int[] num , int target)
        {
            int[] twoSum = new int[2];
            if(target == 0)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < num.Length; i++)
                {
                    int sum = num[i] + num[i + 1];
                    if(target - sum == 0)
                    {
                       twoSum = new int[] { i , i + 1};
                    }
                }
            }

            return twoSum;
        }
    }
}
