using GraphImplementation;
using stack_and_queue;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BreadthFirstGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static List<Node<string>> BreadthFirst( Vertex<string> vertex)
        {


            // Mark all the vertices as not 
            // visited(By default set as false)  
            bool[] visited = new bool[]();
            for (int i = 0; i < _V; i++)
                visited[i] = false;

            // Create a queue for BFS  
            LinkedList<int> queue = new LinkedList<int>();

            // Mark the current node as  
            // visited and enqueue it  
            visited[s] = true;
            queue.AddLast(s);

            while (queue.Any())
            {

                // Dequeue a vertex from queue  
                // and print it 
                s = queue.First();
                Console.Write(s + " ");
                queue.RemoveFirst();

                // Get all adjacent vertices of the  
                // dequeued vertex s. If a adjacent 
                // has not been visited, then mark it  
                // visited and enqueue it  
                LinkedList<int> list = _adj[s];

                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }
        }

    }
}
