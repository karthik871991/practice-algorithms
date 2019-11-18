using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice.MS
{
    public class StringWithout3IdenticalConsecutiveLetters
    {
        public string GetLongestSubString(string str)
        {
            return GetLongestSubString(str, 2);
        }

        private string GetLongestSubString(string str, int count)
        {
            if (string.IsNullOrWhiteSpace(str) || str.Length == 1 || str.Length == 2)
                return str;

            var sb = new StringBuilder();

            for (int i = 0; i < str.Length;)
            {
                int j = i + 1;

                int c = 1;

                sb.Append(str[i]);

                while (j < str.Length && str[i] == str[j])
                {
                    c++;
                    j++;

                    if (c > count)
                        continue;
                    else
                        sb.Append(str[i]);
                }

                i = j;
            }

            return sb.ToString();
        }
    }
}
