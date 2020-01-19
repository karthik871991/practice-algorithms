using System.Collections.Generic;

namespace AlgoPractice
{
    public class LRUCache
    {
        private Node Head = null;
        private Node Tail = null;
        private Dictionary<int, Node> Map;
        private int Count;
        private int Total;
        public LRUCache(int capacity)
        {
            Head = new Node();
            Tail = new Node();
            Count = 0;
            Total = capacity;
            Map = new Dictionary<int, Node>(capacity);
            Head.Previous = Tail;
            Tail.Next = Head;
        }

        public int Get(int key)
        {
            if (Map.ContainsKey(key))
            {
                var node = Map[key];
                Remove(node);
                AddToFront(node);
                return node.Value;
            }

            return -1;
        }


        public void Put(int key, int value)
        {
            if (Map.ContainsKey(key))
                return;

            var node = new Node { Key = key, Value = value };
            if (Count < Total)
            {
                AddToFront(node);
            }
            else
            {
                var nodeToRemove = Tail.Next;
                Remove(nodeToRemove);
                AddToFront(node);
            }
        }

        private void Remove(Node node)
        {
            Map.Remove(node.Key);
            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;
            Count--;
        }

        private void AddToFront(Node node)
        {
            var previous = Head.Previous;
            node.Next = Head;
            node.Previous = previous;
            Head.Previous = node;
            previous.Next = node;
            Map.Add(node.Key, node);
            Count++;
        }
        public Node GetHead()
        {
            return Head.Previous;
        }
        public class Node
        {
            public Node Previous;
            public Node Next;
            public int Key;
            public int Value;
        }
        //public Node Head = null;
        //public Node Tail = null;
        //public int Capacity = 0;
        //public int Count = 0;
        //public Dictionary<int, Node> KeyValuePairs;

        //public LRUCache(int capacity)
        //{
        //    Capacity = capacity;
        //    KeyValuePairs = new Dictionary<int, Node>();

        //    Head = new Node();
        //    Tail = new Node();

        //    Head.Previous = Tail;
        //    Tail.Next = Head;
        //}

        //public int Get(int key)
        //{
        //    if (KeyValuePairs.ContainsKey(key))
        //    {
        //        var node = KeyValuePairs[key];
        //        Remove(node);
        //        AddToFront(node);
        //        KeyValuePairs.Remove(key);
        //        KeyValuePairs.Add(key, node);
        //        return node.Value;
        //    } 
        //    return -1;
        //}

        //public void Put(int key, int value)
        //{
        //    if (KeyValuePairs.ContainsKey(key))
        //    {
        //        var currentNode = KeyValuePairs[key];
        //        currentNode.Value = value;
        //        Remove(currentNode);
        //        AddToFront(currentNode);
        //        KeyValuePairs.Remove(key);
        //        KeyValuePairs.Add(key, Head.Previous);
        //    }
        //    else
        //    {
        //        var node = new Node { Key = key, Value = value };
        //        if (Count < Capacity)
        //        {
        //            AddToFront(node);
        //            KeyValuePairs.Add(key, Head.Previous);
        //            Count++;
        //        }
        //        else
        //        {
        //            KeyValuePairs.Remove(Tail.Next.Key);
        //            Remove(Tail.Next);
        //            AddToFront(node);
        //            KeyValuePairs.Add(key, Head.Previous);
        //        }
        //    }
        //}

        //private void Remove(Node node)
        //{
        //    node.Previous.Next = node.Next;
        //    node.Next.Previous = node.Previous;
        //}

        //private void AddToFront(Node node)
        //{
        //    var previous = Head.Previous;
        //    node.Previous = previous;
        //    node.Next = Head;
        //    Head.Previous = node;
        //    previous.Next = node;
        //}

        //public Node GetHead()
        //{
        //    return Head.Previous;
        //}

        //public Node GetTail()
        //{
        //    return Tail.Next;
        //}

        //public class Node
        //{
        //    public Node Previous;
        //    public int Key;
        //    public int Value;
        //    public Node Next;
        //}
    }
}