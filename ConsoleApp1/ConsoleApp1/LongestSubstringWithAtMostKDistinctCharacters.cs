using System;
using System.Collections.Generic;

namespace AlgoPractice
{
    public class LongestSubstringWithAtMostKDistinctCharacters
    {
        public int LengthOfLongestSubstringKDistinct(string s, int k)
        {
            var i = 0;
            var j = 0;
            var result = 0;
            var map = new Dictionary<char, int>();

            for (; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    map.Add(s[i], 1);
                    // check for greater than k
                    if (map.Count > k)
                    {
                        while (map.Count > k)
                        {
                            map[s[j]]--;

                            if (map[s[j]] == 0)
                            {
                                map.Remove(s[j]);
                            }

                            j++;
                        }
                    }
                }
                else
                {
                    map[s[i]]++;
                }

                result = Math.Max(result, i - j + 1);
            }

            return result;
        }

        public int SubstringKDistinctCount(string s, int k)
        {
            var i = 0;
            var j = 0;
            var result = 0;
            var map = new Dictionary<char, int>();
            var distinct = 0;
            var count = 0;

            for (; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    if (distinct < k)
                    {
                        distinct++;
                    }
                    map.Add(s[i], 1);
                    // check for greater than k
                    //if (map.Count == k)
                    //{
                    //    count++;
                    //}
                    if (map.Count > k)
                    {
                        while (map.Count > k)
                        {
                            count++;
                            map[s[j]]--;

                            if (map[s[j]] == 0)
                            {
                                map.Remove(s[j]);
                            }

                            j++;
                        }
                    }

                    if (distinct == k)
                    {
                        count++;
                    }
                }
                else
                {
                    //count++;
                    map[s[i]]++;
                }

                result = Math.Max(result, i - j + 1);
            }

            return count;
        }
    }
}
