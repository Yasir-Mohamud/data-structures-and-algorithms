using GraphImplementation;
using stack_and_queue;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BreadthFirstGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static List<Node<string>> BreadthFirst(string vertex)
        {

            List<Node<string>> nodes = new List<Node<string>>();
            Queues<string> breadth = new Queues<string>();
            breadth.Enqueue(vertex);


            while (!breadth.IsEmpty())
            {
                 Node<string> front = breadth.Dequeue();
                nodes.Add(front.Value);

                foreach (string child in front)
                {
                    if (!child.visited)
                    {
                        child.Visited = true;
                        breadth.Enqueue(child);
                    }
                }
                return nodes;
            }
        }
    }
}
