﻿using HashTableImplamentation;
using System;

namespace RepeatedWord
{
    public class Class1
    {
        /// <summary>
        /// finds the first word that repeats in a string 
        /// </summary>
        /// <param name="sentence"> the inputted string</param>
        /// <returns>  the repeated word in the string</returns>
         public static string FindRepeatedWord(string sentence)
        {
            char[] charArray = new char[] { ',', '/', '!', ' ', '?' };
            string[] stringArr = sentence.Split(charArray);
           
            int v = 0;
            string repeat = "Not Found";
            HashTable<int> Table = new HashTable<int>(sentence.Length * 2);
            foreach (string item in stringArr)
            {
                if (Table.Contains(item.ToUpper()))
                {
                    return repeat = item.ToLower();
                    
                }
                else
                {
                    Table.Add(item.ToUpper(), v);
                    v++;
                  
                }
            }
   
            return repeat;

        }
    }
}
