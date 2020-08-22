using System;
using System.Collections.Generic;

namespace GraphImplementation
{
    public class graph<T,W>
    {
        /// Adjacency List
        public Dictionary<Vertex<T>,List<Edge<T,W>>> AdjacencyList { get; set; }

        public graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T, W>>>();
        }
        //Add a Node
        public Vertex<T> AddVertex(T vertex)
        {

        }
    }
}
