using AlgoPractice.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.TreeTests
{
    [TestClass]
    public class TreeTests
    {
        [TestMethod]
        public void TestTree()
        {
            var tree = new Tree();
            
            tree.BuildTree(10);
            tree.BuildTree(20);
            tree.BuildTree(30);
            tree.BuildTree(40);
            tree.BuildTree(50);

            var root = tree.GetRoot();

        }
    }
}