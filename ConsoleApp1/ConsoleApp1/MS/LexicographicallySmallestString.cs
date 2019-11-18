using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice.MS
{
    public class LexicographicallySmallestString
    {
        public string LexiSmallestString(string str)
        {
            if (string.IsNullOrWhiteSpace(str) || str.Length == 1)
                return str;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] > str[i + 1])
                {
                    return str.Substring(0, i) + str.Substring(i + 1, str.Length - i - 1);
                }
            }

            return str.Remove(str.Length - 1);
        }
    }
}
