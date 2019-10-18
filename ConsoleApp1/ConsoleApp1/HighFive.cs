using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice
{
    public class HighFives
    {
        public class Data
        {
            public List<int> List { get; set; }
        }
        public int[][] HighFive(int[][] items)
        {
            var map = new Dictionary<int, Data>();

            for (int i = 0; i < items.Length; i++)
            {
                if (!map.ContainsKey(items[i][0]))
                {
                    map.Add(items[i][0], new Data { List = new List<int> { items[i][1] } });
                }
                else
                {
                    map[items[i][0]].List.Add(items[i][1]);
                }
            }

            var sortedMap = map.OrderBy(x => x.Key).ThenBy(x => x.Value.List.OrderByDescending(y => y).Take(5).Sum() / 5);

            var result = new int[map.Count][];
            int m = 0;
            foreach (var item in sortedMap)
            {
                result[m++] = new int[] { item.Key, item.Value.List.OrderByDescending(y => y).Take(5).Sum() / 5 };
            }

            return result;
        }
    }
}