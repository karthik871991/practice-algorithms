using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractice
{
    public class SortCharactersByFrequency
    {
        public string FrequencySort(string s)
        {
            var map = new Dictionary<char, int>();

            foreach (var c in s)
            {
                if (!map.ContainsKey(c))
                {
                    map.Add(c, 1);
                }
                else
                {
                    map[c]++;
                }
            }

            var sortedMap = map.OrderByDescending(x => x.Value);

            var sb = new StringBuilder();

            foreach (var item in sortedMap)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    sb.Append(item.Key);
                }
            }

            return sb.ToString();
        }
    }
}
