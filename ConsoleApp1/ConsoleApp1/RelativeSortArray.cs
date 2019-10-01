using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractice
{
    public class RelativeSortArray
    {
        public int[] RelativeSortArrays(int[] arr1, int[] arr2)
        {
            var map = new Dictionary<int, int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                if (!map.ContainsKey(arr1[i]))
                {
                    map.Add(arr1[i], 1);
                }
                else
                {
                    map[arr1[i]]++;
                }
            }

            int z = 0;

            for (int i = 0; i < arr2.Length; i++)
            {
                while (map.ContainsKey(arr2[i]) && map[arr2[i]] >= 0)
                {
                    arr1[z++] = arr2[i];
                    map[arr2[i]]--;
                    if (map[arr2[i]] == 0)
                    {
                        map.Remove(arr2[i]);
                    }
                }
            }

            foreach (var item in map.OrderBy(x => x.Key))
            {
                for (int j = 0; j < item.Value; j++)
                {
                    arr1[z++] = item.Key;
                }
            }

            return arr1;
        }
    }
}
