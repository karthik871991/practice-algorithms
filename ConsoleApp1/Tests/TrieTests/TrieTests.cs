using AlgoPractice.Trie;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests.TrieTests
{
    [TestClass]
    public class TrieTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var trie = new Trie();
            trie.Add("word");
            trie.Add("word1");
            trie.Add("word2");
            trie.Add("word3");
            trie.Add("word10");
            trie.Add("abcd");
            trie.Add("adbc");
            trie.Add("acdb");
            trie.Add("abdc");

            Assert.IsTrue(trie.Contains("word"));
            Assert.IsTrue(trie.Contains("word1"));
            Assert.IsTrue(trie.Contains("word2"));
            Assert.IsTrue(trie.Contains("word3"));
            Assert.IsTrue(trie.Contains("word10"));
            Assert.IsFalse(trie.Contains("sample"));
            Assert.IsFalse(trie.Contains("wodr3"));

            CollectionAssert.AreEquivalent(new List<string> { "word1", "word10" }, trie.SearchByPrefix("word1"));
            CollectionAssert.AreEquivalent(new List<string> { "word10" }, trie.SearchByPrefix("word10"));
            CollectionAssert.AreEqual(new List<string> { "abcd", "abdc", "acdb", "adbc" }, trie.SearchByPrefix("a"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var trie = new Trie();
            var list = new List<string> { "mobile", "mouse", "moneypot", "monitor", "mousepad" };

            foreach (var word in list)
            {
                trie.Add(word);
            }

            CollectionAssert.AreEqual(new List<string> { "mobile", "moneypot", "monitor" }, trie.SearchByPrefix("m"));
            CollectionAssert.AreEqual(new List<string> { "mobile", "moneypot", "monitor" }, trie.SearchByPrefix("mo"));
            CollectionAssert.AreEqual(new List<string> { "mouse", "mousepad" }, trie.SearchByPrefix("mou"));
            CollectionAssert.AreEqual(new List<string> { "mouse", "mousepad" }, trie.SearchByPrefix("mous"));
            CollectionAssert.AreEqual(new List<string> { "mouse", "mousepad" }, trie.SearchByPrefix("mouse"));
        }
    }
}