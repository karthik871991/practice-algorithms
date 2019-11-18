using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice.MS
{
    public class MinMovestoObtainStringWithout3IdenticalConsecutiveLetters
    {
        public int MinNoMoves(string str)
        {
            var result = 0;

            for (int i = 0; i < str.Length; i++)
            {
                var max = 1;
                while (i + 1 < str.Length && str[i] == str[i + 1])
                {
                    max++;
                    i++;
                }
                result += max / 3;
            }

            return result;
        }
    }
}
