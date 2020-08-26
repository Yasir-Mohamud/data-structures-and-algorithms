using System;

namespace BreadthFirstGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static List<Nodes> BreadthFirst(Node<T> vertex)
        {

            List<Node> nodes<--new List();
            Queue breadth<--new Queue();
            breadth.Enqueue(vertex)


        while (!breadth.IsEmty())
            {
                var front = breadth.Dequeue();
                nodes.Add(front);

                foreach (var child in front.Children)
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
