using GraphImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void AddVertexToGraph()
        {
            // Arrange
            Graph<string, int> graph = new Graph<string, int>();
            // Act

            graph.AddVertex("Washington");

            // Assert
            Assert.NotNull(graph);
        }

        [Fact]
        public void AddDirectedEdge()
        {
            // Arrange
            Graph<string, int> graph = new Graph<string, int>();

            //Act 

            var a = graph.AddVertex("Washington");
            var b = graph.AddVertex("California");

            graph.AddDirectedEdge(a, b, 100);

            var data = graph.AdjacencyList[a].Count;
            var destination = graph.AdjacencyList[a].FirstOrDefault(x => x.Vertex == b);

            Assert.Equal(1, data);
            Assert.Equal(100, destination.Weight);
            Assert.NotNull(destination);
            Assert.NotNull(destination.Vertex);
        }

        [Fact]
        public void AddUndirectedEdge()
        {
            // Arrange
            Graph<string, int> graph = new Graph<string, int>();

            //Act 
            var a = graph.AddVertex("Washington");
            var b = graph.AddVertex("California");

            graph.AddUndirectedEdge(a, b, 50);

            var countA = graph.AdjacencyList[a].Count;
            var countB = graph.AdjacencyList[b].Count;

            var destinationA = graph.AdjacencyList[a].FirstOrDefault(x => x.Vertex == b);
            var destinationB = graph.AdjacencyList[b].FirstOrDefault(x => x.Vertex == a);


            Assert.Equal(1, countA);
            Assert.Equal(1, countB);
            Assert.Equal(50, destinationA.Weight);
            Assert.Equal(50, destinationB.Weight);



        }

        [Fact]
        public void GetNeighbors()
        {
            Graph<string, int> graph = new Graph<string, int>();

            //Act 
            var a = graph.AddVertex("Washington");
            var b = graph.AddVertex("California");
            var c = graph.AddVertex("Texas");


            graph.AddUndirectedEdge(a, b, 50);
            graph.AddUndirectedEdge(a, c, 150);

            var count = graph.AdjacencyList[a].Count;

            Assert.Equal(2, count);

        }

        [Fact]
        public void CanTestHappyPathForBreadthFirstTraversal()
        {
            //Arrange
            Graph<string, int> graph = new Graph<string, int>();


            Vertex<string> vertex1 = graph.AddVertex("Pandora");
            Vertex<string> vertex2 = graph.AddVertex("Arendelle");
            Vertex<string> vertex3 = graph.AddVertex("Metroville");
            Vertex<string> vertex4 = graph.AddVertex("Monstroplolis");
            Vertex<string> vertex5 = graph.AddVertex("Narnia");
            Vertex<string> vertex6 = graph.AddVertex("Naboo");

            graph.AddDirectedEdge(vertex1, vertex2, 50);
            graph.AddDirectedEdge(vertex2, vertex3, 25);
            graph.AddDirectedEdge(vertex3, vertex4, 25);
            graph.AddDirectedEdge(vertex4, vertex5, 25);
            graph.AddDirectedEdge(vertex5, vertex6, 25);
         

            List<Vertex<string>> Expected = new List<Vertex<string>>();
            Expected.Add(vertex1);
            Expected.Add(vertex2);
            Expected.Add(vertex3);
            Expected.Add(vertex4);
            Expected.Add(vertex5);
            Expected.Add(vertex6);
    
            List<Vertex<string>> BreadthFirst = graph.BreadthFirst(vertex1);

       
            Assert.Equal(Expected, BreadthFirst);
     
        }


        [Fact]
        public void CanTestExpectedFailureForBreadthFirstTraversal()
        {
            //Arrange
            Graph<string, int> graph = new Graph<string, int>();


            Vertex<string> vertex1 = graph.AddVertex("Pandora");
            Vertex<string> vertex2 = graph.AddVertex("Arendelle");
            Vertex<string> vertex3 = graph.AddVertex("Metroville");
            Vertex<string> vertex4 = graph.AddVertex("Monstroplolis");
            Vertex<string> vertex5 = graph.AddVertex("Narnia");
            Vertex<string> vertex6 = graph.AddVertex("Naboo");

            graph.AddDirectedEdge(vertex1, vertex2, 50);
            graph.AddDirectedEdge(vertex2, vertex3, 25);
            graph.AddDirectedEdge(vertex3, vertex4, 25);
            graph.AddDirectedEdge(vertex4, vertex5, 25);
            graph.AddDirectedEdge(vertex5, vertex6, 25);


            List<Vertex<string>> Expected = new List<Vertex<string>>();
            Expected.Add(vertex1);
            Expected.Add(vertex5);
            Expected.Add(vertex2);
            Expected.Add(vertex3);
            Expected.Add(vertex6);
            Expected.Add(vertex4);

            List<Vertex<string>> BreadthFirst = graph.BreadthFirst(vertex1);


            Assert.NotEqual(Expected, BreadthFirst);

        }


        [Fact]
        public void CanTestHappyPathForDepthFirstTraversal()
        {
            //Arrange
            Graph<string, int> graph = new Graph<string, int>();


            Vertex<string> vertex1 = graph.AddVertex("A");
            Vertex<string> vertex2 = graph.AddVertex("B");
            Vertex<string> vertex3 = graph.AddVertex("C");
            Vertex<string> vertex4 = graph.AddVertex("D");
            Vertex<string> vertex5 = graph.AddVertex("E");
            Vertex<string> vertex6 = graph.AddVertex("F");
            Vertex<string> vertex7 = graph.AddVertex("G");
            Vertex<string> vertex8 = graph.AddVertex("H");


            graph.AddDirectedEdge(vertex1, vertex2, 50);
            graph.AddDirectedEdge(vertex1, vertex4, 25);
            graph.AddDirectedEdge(vertex2, vertex4, 25);
            graph.AddDirectedEdge(vertex2, vertex3, 25);
            graph.AddDirectedEdge(vertex2, vertex7, 25);
            graph.AddDirectedEdge(vertex4, vertex5, 25);
            graph.AddDirectedEdge(vertex4, vertex6, 25);
            graph.AddDirectedEdge(vertex4, vertex8, 25);
            graph.AddDirectedEdge(vertex6, vertex8, 25);


            HashSet<Vertex<string>> Expected = new HashSet<Vertex<string>>();
            Expected.Add(vertex1);
            Expected.Add(vertex2);
            Expected.Add(vertex3);
            Expected.Add(vertex7);
            Expected.Add(vertex4);
            Expected.Add(vertex5);
            Expected.Add(vertex8);
            Expected.Add(vertex6);

            HashSet<Vertex<string>> BreadthFirst = graph.DepthFirst();


            Assert.Equal(Expected, BreadthFirst);

        }

    }
}
