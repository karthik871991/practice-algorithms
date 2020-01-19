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