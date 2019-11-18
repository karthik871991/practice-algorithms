using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice.MS
{
    public class MaxNetworkRank
    {
        public int MaxRank(int[] A, int[] B, int N)
        {
            var result = 0;

            var map = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < A.Length; i++)
            {
                AddEdge(A[i], B[i], map);
                AddEdge(B[i], A[i], map);
            }

            for (int i = 0; i < A.Length; i++)
            {
                result = Math.Max(result, map[A[i]].Count + map[B[i]].Count - 1);
            }

            return result;
        }

        private void AddEdge(int a, int b, Dictionary<int, HashSet<int>> map)
        {
            if (map.ContainsKey(a))
            {
                map[a].Add(b);
            }
            else
            {
                map.Add(a, new HashSet<int> { b });
            }
        }

        public int MaxRankEasy(int[] A, int[] B, int N)
        {
            var result = 0;

            var map = new Dictionary<int, int>();

            return result;
        }
    }
}