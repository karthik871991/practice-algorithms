using System;
using System.Collections.Generic;

namespace AlgoPractice.MS
{
    public class NumbersWithEqualDigitSum
    {
        public int MaxSum(int[] A)
        {
            var map = new Dictionary<int, int>();

            var result = -1;

            for (int i = 0; i < A.Length; i++)
            {
                var digitSum = Sum(A[i]);

                if (map.ContainsKey(digitSum))
                {
                    result = Math.Max(result, map[digitSum] + A[i]);
                    map[digitSum] = Math.Max(map[digitSum], A[i]);
                }
                else
                {
                    map.Add(digitSum, A[i]);
                }
            }

            return result;
        }

        private int Sum(int num)
        {
            var result = 0;

            num = Math.Abs(num);

            while (num > 0)
            {
                result += num % 10;
                num /= 10;
            }

            return result;
        }
    }
}