using System;
using System.Collections.Generic;
using Trees;

namespace TreeIntersection
{
    public class Class1
    {

        /// <summary>
        /// Takes in two trees and returns a list of values found in both trees
        /// </summary>
        /// <param name="tree1"> inputted tree</param>
        /// <param name="tree2">inputted tree</param>
        /// <returns>list of values found in tree1 and tree2</returns>
        public static List<int> TreeIntersectionMethod(Tree<int> tree1, Tree<int> tree2)
        {
            List<int> list = new List<int>();
  
            List<int> list1 = tree1.PreOrder(tree1.Root);
            List<int> list2 = tree2.PreOrder(tree2.Root);
            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1[i] == list2[j])
                    {
                        list.Add(list2[j]);
                    }
                }
            }
            return list;
        }


    }
}




