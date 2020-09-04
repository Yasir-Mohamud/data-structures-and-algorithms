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
        static LinkedListNode<T> head = null; 

        static void Main(string[] args)
        {
        }

        public int RemoveDup ()
        {

        LinkedList<int> list = new LinkedList<int>();
            LinkedListNode<int> a = new LinkedListNode<int>(11);
            LinkedListNode<int> b = new LinkedListNode<int>(1);
            LinkedListNode<int> c= new LinkedListNode<int>(100);
            LinkedListNode<int> d = new LinkedListNode<int>(200);
            LinkedListNode<int> e = new LinkedListNode<int>(191);
            list.AddFirst(10);
          
                list.a

        }

        static void push(int data)
        {
            // Allocate dynamic memory for newNode.  
            LinkedListNode<int> newNode = new LinkedListNode<int>(data);

       

            // newNode->next assign the address of  
            // head node.  
            newNode.Next = (head);

            // newNode become the headNode.  
            (head) = newNode;
        }






    }
}

