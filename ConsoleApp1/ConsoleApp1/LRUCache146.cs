using System.Collections.Generic;

namespace AlgoPractice
{
    public class LRUCache
    {
        public Node Head = null;
        public Node Tail = null;
        public int Capacity = 0;
        public Dictionary<int, Node> KeyValuePairs;

        public LRUCache(int capacity)
        {
            Capacity = capacity;
            KeyValuePairs = new Dictionary<int, Node>();

            Head = new Node();
            Tail = new Node();

            Head.Previous = Tail;
            Tail.Next = Head;
        }

        public int Get(int key)
        {
            if (KeyValuePairs.ContainsKey(key))
            {
                var node = KeyValuePairs[key];
                Remove(key);
                AddToFront(node.Key, node.Value);
                return node.Value;
            }
            return 0;
        }

        public void Put(int key, int value)
        {
            if (KeyValuePairs.ContainsKey(key))
            {
                Remove(key);
                AddToFront(key, value);
            }
            else
            {
                AddToFront(key, value);
                KeyValuePairs.Add(key, Head.Previous);                
            }
        }

        private void Remove(int key)
        {
            var currentNode = KeyValuePairs[key];
            KeyValuePairs.Remove(key);

            currentNode.Previous.Next = currentNode.Next;
            currentNode.Next.Previous = currentNode.Previous;
        }

        private void AddToFront(int key, int value)
        {
            var node = new Node { Key = key, Value = value };
            var previous = Head.Previous;
            node.Previous = previous;
            node.Next = Head;
            Head.Previous = node;
            previous.Next = node;
        }

        public Node GetHead()
        {
            return Head.Previous;
        }

        public Node GetTail()
        {
            return Tail.Next;
        }

        public class Node
        {
            public Node Previous;
            public int Key;
            public int Value;
            public Node Next;
        }
    }
}