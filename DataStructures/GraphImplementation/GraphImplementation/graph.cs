using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphImplementation
{
    public class Graph<T,W>
    {

        // Adjacency List
        // Key is the vertex
        // value is the list of edges with a specific data type as weigh and conencted to a specific vertex
        public Dictionary<Vertex<T>, List<Edge<T, W>>> AdjacencyList { get; set; }
        private int _size = 0;

        public Graph()
        {
            // We have to allocate memory on the heap for the collection.
            // Null reference exception if we do not do this because "nothing will exist"
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T, W>>>();
        }

        // Add vertex/node
        public Vertex<T> AddVertex(T value)
        {
            Vertex<T> vertex = new Vertex<T>(value);
            AdjacencyList.Add(vertex, new List<Edge<T, W>>());
            // change the size of the graph by addine a single vertex
            _size++;
            return vertex;
        }

        // add Edge
        public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, W weight)
        {
            // add this edge to vertex B
            // a is our source
            // b is our destination
            // weight is the value of the edge
            Edge<T, W> edge = new Edge<T, W>
            {
                Vertex = b,
                Weight = weight
            };
            AdjacencyList[a].Add(edge);
        }

        public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, W weight)
        {
            AddDirectedEdge(a, b, weight);
            AddDirectedEdge(b, a, weight);

        }

        public List<Edge<T, W>> GetNeighbors(Vertex<T> vertex)
        {
            return AdjacencyList[vertex];
        }

        // get a single vertex

        public Vertex<T> GetVertex(T value)
        {
            // traverse over our Adjacency list
            // see if the value that we are chedkcing for exists in a single vertex. 
            // Do the any of the vertices have this value?
            // we are assuming no duplicates
            // If this was duplicates, make the return type a list<vertex<t>> and then just 
            // add the vertex to the list and return the list from the method

            foreach (var vetex in AdjacencyList)
            {
                if (vetex.Key.Value.Equals(value))
                {
                    return vetex.Key;
                }
            }

            return null;
        }


        public List<Vertex<T>> GetAllVertices()
        {
            List<Vertex<T>> vertices = new List<Vertex<T>>();
            foreach (var vertex in AdjacencyList)
            {
                vertices.Add(vertex.Key);

            }

            return vertices;

        }

        public int Size()
        {
            // return the number of vertices in the graph
            return _size;
        }

        public void Print()
        {
            foreach (var item in AdjacencyList)
            {
                Console.Write($"Vertex {item.Key.Value} ->");

                foreach (var edge in item.Value)
                {
                    Console.Write($"{edge.Vertex.Value}, {edge.Weight} ->");
                }

                Console.WriteLine("null");

            }
        }

        /// <summary>
        /// Traverses a graph Breadth first
        /// </summary>
        /// <param name="vertex">inputted vertex</param>
        /// <returns>List of all vetices in the graph </returns>
        public List<Vertex<T>> BreadthFirst(Vertex<T> vertex)
        {
                 List<Vertex<T>> list = new List<Vertex<T>>();
                 Queue<Vertex<T>> breadth = new Queue<Vertex<T>>();

            breadth.Enqueue(vertex);

            while(breadth.Count() != 0)
            {
                Vertex<T> front = breadth.Dequeue();
            List<Edge<T, W>> edges = AdjacencyList[front];
            
                list.Add(front);

                foreach (Edge<T,W> edge in edges)
                {
                    if (edge.Vertex != null & !list.Contains(edge.Vertex))
                    {
                        breadth.Enqueue(edge.Vertex);
                    }
                }
	
            }

            return list;
        }


        public   HashSet<Vertex<T>> DepthFirst()
        {

            Vertex<T> vertex = AdjacencyList.Keys.First();
            Stack<Vertex<T>> stack = new Stack<Vertex<T>>();
            HashSet<Vertex<T>> visited = new HashSet<Vertex<T>>();

            stack.Push(vertex);
            visited.Add(vertex);
            while (stack.Count > 0)
            {
                var v = stack.Pop();
                if (visited.Contains(vertex))
                {
                    continue;
                }
                visited.Add(v);
                foreach (Edge<T, W> edge in AdjacencyList[v])
                    if (!visited.Contains(edge.Vertex))
                        stack.Push(edge.Vertex);
            }

            return visited;


        }
      }
}
