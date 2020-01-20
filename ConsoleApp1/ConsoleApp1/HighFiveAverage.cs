using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice
{
    public class HighFiveAverage
    {
        public int[][] HighFive(int[][] items)
        {
            var map = new Dictionary<int, List<int>>();

            foreach (var item in items)
            {
                if (map.ContainsKey(item[0]))
                {
                    map[item[0]].Add(item[1]);
                }
                else
                {
                    map.Add(item[0], new List<int> { item[1] });
                }
            }

            var result = new int[map.Count][];
            var i = 0;
            foreach (var kvp in map.OrderBy(x => x.Key))
            {
                result[i] = new int[2];
                result[i][0] = kvp.Key;
                result[i][1] = kvp.Value.OrderByDescending(x => x).Take(5).Sum() / 5;
                ++i;
            }

            return result;
        }
    }
}