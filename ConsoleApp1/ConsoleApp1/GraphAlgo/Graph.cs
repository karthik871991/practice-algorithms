using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice.GraphAlgo
{
    public class Graph
    {
        private readonly Dictionary<int, HashSet<int>> list;

        public Graph()
        {
            list = new Dictionary<int, HashSet<int>>();
        }

        public void AddVertex(int v)
        {
            if (!list.ContainsKey(v))
            {
                list.Add(v, new HashSet<int>());
            }
        }

        public void AddEdge(int v1, int v2)
        {
            if (!list.ContainsKey(v1))
                AddVertex(v1);

            if (!list.ContainsKey(v2))
                AddVertex(v2);

            list[v1].Add(v2);
            list[v2].Add(v1);
        }

        public void RemoveEdge(int v1, int v2)
        {
            if(!list.ContainsKey(v1) || !list.ContainsKey(v2))
            {
                return;
            }

            list[v1].Remove(v2);
            list[v2].Remove(v1);
        }

        public List<int> GetAllVertex()
        {
            var result = new List<int>();

            foreach (var key in list.Keys)
            {
                result.Add(key);
            }

            return result;
        }

        public HashSet<int> GetEdgeForVertex(int v)
        {
            if (list.ContainsKey(v))
            {
                return list[v];
            }

            return new HashSet<int>();
        }

        public void RemoveVertex(int v)
        {
            if (list.ContainsKey(v))
            {
                list.Remove(v);

                foreach (var vertex in list.Keys)
                {
                    if (list[vertex].Contains(v))
                    {
                        list[vertex].Remove(v);
                    }
                }
            }
        }
    }
}