using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractice
{
    public class TopKFrequentWords
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var result = new List<string>();

            var map = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!map.ContainsKey(words[i]))
                {
                    map.Add(words[i], 1);
                }
                else
                {
                    map[words[i]]++;
                }
            }

            var sortedDictionary = new SortedSet<KeyValuePair<string, int>>(new CompareObject());

            foreach (var item in map)
            {
                sortedDictionary.Add(item);

                if (sortedDictionary.Count > k)
                    sortedDictionary.Remove(sortedDictionary.Last());
            }

            return sortedDictionary.Select(x => x.Key).ToList();

            //return map.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(k).Select(x => x.Key).ToList();
        }

        public class CompareObject : IComparer<KeyValuePair<string, int>>
        {
            public int Compare(KeyValuePair<string, int> x, KeyValuePair<string, int> y)
            {
                var result = y.Value.CompareTo(x.Value);

                if(result == 0)
                {
                    return x.Key.CompareTo(y.Key);
                }

                return result;
            }
        }
    }
}
