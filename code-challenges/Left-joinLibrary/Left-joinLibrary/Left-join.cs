using HashTableImplamentation;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Left_joinLibrary
{
    public class Class1
    {

        /// <summary>
        /// Lfet joins two dictionaries
        /// </summary>
        /// <param name="dictionary1"> input of first Dictionary</param>
        /// <param name="dictionary2"> input of the second Dictionary</param>
        /// <returns> An array list of left joined dictionaries </returns>
        public static ArrayList LeftJoinMethod(Dictionary<string,string> dictionary1  , Dictionary<string,string> dictionary2)
     {
            ArrayList list = new ArrayList();
         
            foreach(KeyValuePair<string,string> item in dictionary1)
            {
                string[] Output = new string[3];
                Output[0] = item.Key;
                Output[1] = item.Value;
                if (dictionary2.ContainsKey(item.Key))
                {
                    Output[2] = dictionary2[item.Key];
                }
                else
                {
                    Output[2] = null;
                }
                list.Add(Output);
            }
            return list;

        }
    }
}
