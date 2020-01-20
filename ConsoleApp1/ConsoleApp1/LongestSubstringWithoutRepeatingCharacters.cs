using System;
using System.Collections.Generic;

namespace AlgoPractice
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            var max = 0;
            var j = 0;
            var map = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    map.Add(s[i], i);
                }
                else
                {
                    j = Math.Max(j, map[s[i]] + 1);
                    map[s[i]] = i;
                }

                max = Math.Max(max, i - j + 1);
            }

            return max;
        }
    }
}
