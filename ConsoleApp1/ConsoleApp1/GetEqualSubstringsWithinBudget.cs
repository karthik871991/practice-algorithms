using System;

namespace AlgoPractice
{
    public class GetEqualSubstringsWithinBudget
    {
        public int EqualSubstring(string s, string t, int maxCost)
        {
            int j = 0, i = 0;

            for (; i < s.Length; i++)
            {
                maxCost -= Math.Abs(s[i] - t[i]);
                if (maxCost < 0) maxCost += Math.Abs(s[j] - t[j++]);
            }

            return i - j;
        }
    }
}
