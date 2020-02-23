using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Practice
{
    class Solution
    {
        public static void Main(string[] aargs)
        {

        }

        public int MinSetSize(int[] arr)
        {

            var map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    map[arr[i]]++;
                }
                else
                {
                    map.Add(arr[i], 1);
                }
            }

            var list = map.OrderByDescending(x => x.Value).Select(x => x.Value).ToList();//.OrderByDescending<int>().ToList();

            var s = arr.Length / 2;
            var count = 0;
            var sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
                count++;
                if (sum > s)
                    return count;
            }

            return count;
        }

        public int MaxLength(List<string> list)
        {
            var maxLength = 0;

            Explore(list, maxLength, 0, "");

            return maxLength;
        }

        private static void Explore(List<string> list, int maxLength, int index, string path)
        {
            if (!IsUnique(path))
            {
                return;
            }

            var current = path.Length;
            maxLength = current > maxLength ? current : maxLength;

            for (int i = index; i < list.Count; i++)
            {
                Explore(list, maxLength, i + 1, path + list[i]);
            }
        }

        private static bool IsUnique(string path)
        {
            var hashSet = new HashSet<char>(path);
            return path.Length == hashSet.Count();
        }
    }
}