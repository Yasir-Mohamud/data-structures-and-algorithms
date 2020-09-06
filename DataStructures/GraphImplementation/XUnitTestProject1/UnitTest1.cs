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

            graph.AddDirectedEdge(vertex1, vertex2, 1);
            graph.AddDirectedEdge(vertex2, vertex3, 2);
            graph.AddDirectedEdge(vertex3, vertex4, 3);
            graph.AddDirectedEdge(vertex4, vertex5, 4);
            graph.AddDirectedEdge(vertex5, vertex6, 5);
         

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

            graph.AddDirectedEdge(vertex1, vertex2, 1);
            graph.AddDirectedEdge(vertex2, vertex3, 2);
            graph.AddDirectedEdge(vertex3, vertex4, 3);
            graph.AddDirectedEdge(vertex4, vertex5, 4);
            graph.AddDirectedEdge(vertex5, vertex6, 5);


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
        public void CanTestEdgeCasesForBreadthFirstTraversal()
        {
            //Arrange
            Graph<string, int> graph = new Graph<string, int>();


            Vertex<string> vertex1 = graph.AddVertex("Pandora");
            Vertex<string> vertex2 = graph.AddVertex("Arendelle");
            Vertex<string> vertex3 = graph.AddVertex("Metroville");
            Vertex<string> vertex4 = graph.AddVertex("Monstroplolis");
            Vertex<string> vertex5 = graph.AddVertex("Narnia");
            Vertex<string> vertex6 = graph.AddVertex("Naboo");

            graph.AddUndirectedEdge(vertex1, vertex2, 1);
            graph.AddUndirectedEdge(vertex2, vertex3, 2);
            graph.AddUndirectedEdge(vertex3, vertex4, 3);
            graph.AddUndirectedEdge(vertex4, vertex5, 4);
            graph.AddUndirectedEdge(vertex5, vertex6, 5);


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



    }
}
