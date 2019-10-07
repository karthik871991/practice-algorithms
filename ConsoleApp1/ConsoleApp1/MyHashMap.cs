using System.Collections.Generic;

namespace AlgoPractice
{
    public class MyHashMap<K, V>
    {
        private List<Node<K, V>>[] List;

        public MyHashMap()
        {
            List = new List<Node<K, V>>[10000];
        }

        private int GetHashCode(K key)
        {
            return key.GetHashCode() % 10000;
        }

        public void Put(K key, V value)
        {
            var hash = GetHashCode(key);

            if (List[hash] == null)
            {
                List[hash] = new List<Node<K, V>>(10000) { new Node<K, V> { Key = key, Value = value } };
                return;
            }

            var index = List[hash].FindIndex(x => x.Key.Equals(key));

            if (index == -1)
            {
                List[hash].Add(new Node<K, V> { Key = key, Value = value });
            }
            else
            {
                List[hash][index] = new Node<K, V> { Key = key, Value = value };
            }
        }

        public V Get(K key)
        {
            var hash = GetHashCode(key);

            if (List[hash] == null)
            {
                return default(V);
            }

            var index = List[hash].FindIndex(x => x.Key.Equals(key));

            if (index == -1)
                return default(V);

            return List[hash][index].Value;
        }

        public void Remove(K key)
        {
            var hash = GetHashCode(key);

            if (List[hash] != null) 
            {
                var index = List[hash].FindIndex(x => x.Key.Equals(key));

                if (index != -1)
                {
                    List[hash].RemoveAt(index);
                }
            } 
        }

        public class Node<K, V>
        {
            public K Key { get; set; }
            public V Value { get; set; }
        }
    }
}