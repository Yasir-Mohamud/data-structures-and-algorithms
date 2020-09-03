using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using NPOI.SS.Formula.Functions;
using stack_and_queue;
using Trees;

namespace test22
{
   public  class Program
    {
        static void Main(string[] args)
        {
            /*  List<int> list = Man();
              foreach (var item in list)
              {
                 Console.WriteLine(item);
              }*/
            Tree<int> tree = new Tree<int>();

            Trees.Node<int> root = new Trees.Node<int>(1);
            Trees.Node<int> b = new Trees.Node<int>(2);
            Trees.Node<int> c = new Trees.Node<int>(3);
            Trees.Node<int> d = new Trees.Node<int>(4);
            Trees.Node<int> e = new Trees.Node<int>(5);
            Trees.Node<int> f = new Trees.Node<int>(6);
            Trees.Node<int> g = new Trees.Node<int>(7);

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            List<int> list = Man(root);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        // BREADTH FIRST TRAVERSAL
        public static List<int> Man(Trees.Node<int> root)
        {
            List<int> result = new List<int>();
            Man(result, root);
            return result;
        }
        public static void Man(List<int> list, Trees.Node<int> root)
        {

           Queue<Trees.Node<int>> breadth = new Queue<Trees.Node<int>>();
            breadth.Enqueue(root);

            while(breadth.Count > 0)
            {
               Trees.Node<int> Front = breadth.Dequeue();
                list.Add(Front.Value);

                if (Front.LeftChild != null)
                    breadth.Enqueue(Front.LeftChild);
                if (Front.RightChild != null)
                    breadth.Enqueue(Front.RightChild);


            }

        


        }
            

   }
}

