using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice.MS
{
    public class MinDeletionstoMakeFrequencyofEachLetterUnique
    {
        public int MinimumDeletions(string str)
        {
            var fmap = new SortedDictionary<int, int>();

            var map = new Dictionary<char, int>();

            foreach (var c in str)
            {
                if (map.ContainsKey(c))
                {
                    map[c]++;
                }
                else
                {
                    map.Add(c, 1);
                }
            }

            foreach(var kvp in map)
            {
                if (fmap.ContainsKey(kvp.Value))
                {
                    fmap[kvp.Value]++;
                }
                else
                {
                    fmap.Add(kvp.Value, 1);
                }
            }

            int count = 0;

            while(fmap.Count != 0)
            {
                var kvp = fmap.Last();

                fmap.Remove(kvp.Key);

                if(kvp.Key == 1)
                {
                    count += kvp.Value - 1;
                    return count;
                }

                if (kvp.Value > 1)
                {
                    count += kvp.Value - 1;
                    if (fmap.ContainsKey(kvp.Key - 1))
                    {
                        fmap[kvp.Key - 1] += kvp.Value - 1;
                    }
                    else
                    {
                        fmap.Add(kvp.Key - 1, kvp.Value - 1);
                    }
                }
            }
            
            return count;
        }
    }
}
