using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoPractice.GraphAlgo;
using System.Collections.Generic;
using System.Linq;

namespace Tests.GraphTests
{
    [TestClass]
    public class GraphTests
    {
        [TestMethod]
        public void TestGraph()
        {
            var graph = new Graph();
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);

            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 3);

            CollectionAssert.AreEqual(graph.GetAllVertex(), new List<int> { 1, 2, 3 });

            CollectionAssert.AreEqual(graph.GetEdgeForVertex(1).ToList(), new List<int> { 2, 3 });
            CollectionAssert.AreEqual(graph.GetEdgeForVertex(2).ToList(), new List<int> { 1, 3 });
            CollectionAssert.AreEqual(graph.GetEdgeForVertex(3).ToList(), new List<int> { 1, 2 });

            graph.RemoveVertex(1);

            Assert.AreEqual(2, graph.GetAllVertex().Count);
            CollectionAssert.AreEqual(graph.GetEdgeForVertex(2).ToList(), new List<int> { 3 });
            CollectionAssert.AreEqual(graph.GetEdgeForVertex(3).ToList(), new List<int> { 2 });

        }
    }
}