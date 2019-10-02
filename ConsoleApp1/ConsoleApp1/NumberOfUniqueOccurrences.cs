using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractice
{
    public class NumberOfUniqueOccurrences
    {
        public bool UniqueOccurrences(int[] arr)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!map.ContainsKey(arr[i]))
                {
                    map.Add(arr[i], 1);
                }
                else
                {
                    map[arr[i]]++;
                }
            }

            return !map.Values.GroupBy(x=>x).Any(x => x.Count() > 1);
        }
    }
}
