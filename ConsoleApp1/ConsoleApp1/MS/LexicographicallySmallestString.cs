using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice.MS
{
    public class LexicographicallySmallestString
    {
        public string LexiSmallestString(string S)
        {
            if (string.IsNullOrWhiteSpace(S) || S.Length == 1)
                return S;

            for (int i = 0; i < S.Length - 1; i++)
            {
                if (S[i] > S[i + 1])
                {
                    return S.Substring(0, i) + S.Substring(i + 1, S.Length - i - 1);
                }
            }

            return S.Remove(S.Length - 1);
        }
    }
}
