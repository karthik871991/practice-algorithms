using System;
using System.Collections.Generic;

namespace AlgoPractice.MS
{
    public class ReplaceQuestionMark
    {
        public string Solution(string riddle)
        {
            if (string.IsNullOrWhiteSpace(riddle))
                return riddle;

            if (riddle.Length == 1 && riddle[0] == '?')
                return new string(GetCharToInsert(new HashSet<char>()).ToString());

            var charArr = riddle.ToCharArray();

            if (charArr[0] == '?')
                charArr[0] = GetCharToInsert(new HashSet<char> { charArr[1] });

            if (charArr[charArr.Length - 1] == '?')
                charArr[charArr.Length - 1] = GetCharToInsert(new HashSet<char> { charArr[charArr.Length - 2] });

            for (int i = 1; i < charArr.Length - 1; i++)
            {
                if (charArr[i] == '?')
                    charArr[i] = GetCharToInsert(new HashSet<char> { charArr[i - 1], charArr[i + 1] });
            }

            return new string(charArr);
        }

        private char GetCharToInsert(HashSet<char> set)
        {
            for (int i = 97; i < 97 + 3; i++)
            {
                if (!set.Contains((char)i))
                    return (char)i;
            }

            throw new InvalidOperationException();
        }
    }
}
