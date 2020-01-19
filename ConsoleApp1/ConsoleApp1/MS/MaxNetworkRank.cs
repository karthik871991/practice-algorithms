using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice.MS
{
    public class MaxNetworkRank
    {
        public int solution(int[] A, int[] B, int N)
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

        int maxLength = 0;
        public int MaxLength(IList<string> list)
        {
            Explore(list, 0, "");

            return maxLength;
        }


        private void Explore(IList<string> list, int index, string path)
        {
            if (!IsUnique(path))
            {
                return;
            }

            var current = path.Length;
            maxLength = current > maxLength ? current : maxLength;

            for (int i = index; i < list.Count; i++)
            {
                Explore(list, i + 1, path + list[i]);
            }
        }

        private bool IsUnique(string path)
        {
            var hashSet = new HashSet<char>(path);
            return path.Length == hashSet.Count;
        }
    }
}