using System;
using System.Collections.Generic;

namespace AlgoPractice.MS
{
    public class MinSwapstoGroupRedBalls
    {
        public int MinimumSwaps(string str)
        {
            var list = GetRedBallsIndices(str);

            if (list.Count == 1 && str.Length > 1)
                return -1;

            var result = 0;

            var mid = list.Count / 2;

            for (int i = 0; i < list.Count; i++)
            {
                result += Math.Abs(list[mid] - list[i] - (mid - i));
            }

            return result;
        }

        private List<int> GetRedBallsIndices(string str)
        {
            var list = new List<int>(str.Length);

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'R')
                    list.Add(i);
            }

            return list;
        }
    }
}