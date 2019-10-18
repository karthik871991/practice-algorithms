using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice
{
    public class LongestCommonSubsequence
    {
        public int LongestCommonSubsequences(string text1, string text2)
        {
            var lu = new int[text2.Length + 1, text1.Length + 1];

            for (int i = 0; i < text2.Length; i++)
            {
                for (int j = 0; j <text1.Length; j++)
                {
                    if (text1[j] == text2[i])
                        lu[i + 1, j + 1] = lu[i, j] + 1;
                    else
                        lu[i + 1, j + 1] = Math.Max(lu[i + 1, j], lu[i, j + 1]);
                }
            }

            return lu[text2.Length, text1.Length];
        }
    }
}
