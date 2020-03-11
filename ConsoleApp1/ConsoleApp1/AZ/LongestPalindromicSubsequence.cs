using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice.AZ
{
    public class LongestPalindromicSubsequence
    {
        public int longestPalindromeSubseq(string s)
        {
            int[,] dp = new int[s.Length, s.Length];

            for (int i = s.Length - 1; i >= 0; i--)
            {
                dp[i, i] = 1;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        dp[i, j] = dp[i + 1, j - 1] + 2;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i + 1, j], dp[i, j - 1]);
                    }
                }
            }
            return dp[0, s.Length - 1];
        }

        //public static void Main()
        //{
        //    var sut = new LongestPalindromicSubsequence().longestPalindromeSubseq("bbbab");
        //    Assert.AreEqual(7, sut);
        //}
    }
}