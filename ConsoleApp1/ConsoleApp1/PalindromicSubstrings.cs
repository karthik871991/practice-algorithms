using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice
{
    public class PalindromicSubstrings
    {
        public int CountSubstrings(string s)
        {
            var mat = new int[s.Length, s.Length];

            var result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                mat[i, i] = 1;
                result++;
            }

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    mat[i, i + 1] = 1;
                    result++;
                }
            }

            for (int i = 2; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length - i; j++)
                {
                    if (s[j] == s[i + j] && mat[j + 1, i + j - 1] == 1)
                    {
                        mat[j, i + j] = 1;
                        result++;
                    }
                    else
                    {
                        mat[j, i + j] = 0;
                    }
                }
            }

            return result;
        }
    }
}
