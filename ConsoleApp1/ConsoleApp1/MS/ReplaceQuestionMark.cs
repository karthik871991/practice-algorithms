using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice.MS
{
    public class ReplaceQuestionMark
    {
        public string Solution(string riddle)
        {
            var c = "a";

            if (string.IsNullOrWhiteSpace(riddle) || (riddle.Length == 1 && riddle[0] == '?'))
                return c;

            var charArr = riddle.ToCharArray();

            if (charArr[0] == '?')
            {
                var ch = ((int)charArr[1] + 1);

                if (ch > 96 && ch < 123)
                {
                    charArr[0] = char.IsLetter(charArr[1]) ? (char)ch : 'a';
                }
                else
                {
                    charArr[0] = char.IsLetter(charArr[1]) ? (char)(ch - 2) : 'a';
                }

                charArr[0] = char.IsLetter(charArr[1]) ? (char)((int)charArr[1] + 1) : 'a';
            }

            if (charArr[charArr.Length - 1] == '?')
            {
                var ch = ((int)charArr[1] + 1);

                if (ch > 96 && ch < 123)
                {
                    charArr[charArr.Length - 1] = char.IsLetter(charArr[charArr.Length - 1]) ? (char)ch : 'a';
                }
                else
                {
                    charArr[charArr.Length - 1] = char.IsLetter(charArr[charArr.Length - 1]) ? (char)(ch - 2) : 'a';
                }

            }

            for (int i = 1; i < charArr.Length - 1; i++)
            {
                if (charArr[i] == '?')
                {
                    var left = charArr[i - 1];
                    var right = charArr[i + 1];
                    var ch = (char)((int)left + 1);

                    if (ch > 96 && ch < 123)
                    {
                        charArr[i] = right == '?' ? (char)(ch) : (char)(ch - 2);
                    }
                    else
                    {
                        charArr[i] = right == '?' ? (char)(ch - 2) : (char)(ch);
                    }
                }
            }

            return new string(charArr);
        }
    }
}
