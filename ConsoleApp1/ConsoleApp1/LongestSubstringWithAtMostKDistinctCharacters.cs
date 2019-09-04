using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice
{
    public class LongestSubstringWithAtMostKDistinctCharacters
    {
        public int LengthOfLongestSubstringTwoDistinct(string s)
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
                }
                else
                {

                }
                result = Math.Max(result, i - j + 1);
            }

            return 0;
        }
    }
}
