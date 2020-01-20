using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice.Trie
{
    public class Trie
    {
        private Node _head = new Node();

        public void Add(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return;

            AddWord(word);
        }

        private void AddWord(string word)
        {
            var node = _head;

            foreach (var ch in word)
            {
                if (node.Childs[ch] == null)
                {
                    node.Childs[ch] = new Node();
                }

                if (node.Childs[ch].Char != ch)
                {
                    node.Childs[ch].Char = ch;
                }

                node = node.Childs[ch];
            }

            node.IsEnd = true;
        }

        public List<string> SearchByPrefix(string prefix)
        {
            var node = _head;

            var result = new List<string>();

            foreach (var ch in prefix)
            {
                if (node.Childs[ch] == null)
                    return result;

                if (node.Childs[ch].Char == ch)
                    node = node.Childs[ch];
            }
            
            DFSPrintAllWords(node, result, prefix);

            return result;
        }

        private void DFSPrintAllWords(Node node, List<string> list, string word)
        {
            if (node.IsEnd)
                list.Add(word);

            foreach (var n in node.Childs)
            {
                if (n != null)
                    DFSPrintAllWords(n, list, word + n.Char);
            }
        }

        public bool Contains(string word)
        {
            var node = _head;

            foreach (var ch in word)
            {
                if (node.Childs[ch] != null && node.Childs[ch].Char == ch)
                {
                    node = node.Childs[ch];
                }
            }

            return node.IsEnd;
        }
    }

    public class Node
    {
        public char Char { get; set; }
        public bool IsEnd { get; set; }
        public Node[] Childs { get; set; } = new Node[256];
    }
}