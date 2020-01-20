using System;
using System.Collections.Generic;

namespace AlgoPractice.MS
{
    public class LargestInteger
    {
        public int LargestInt(int[] A)
        {
            var set = new HashSet<int>();

            var result = 0;

            for (int i = 0; i < A.Length; i++)
            {
                set.Add(-A[i]);

                if (set.Contains(A[i]))
                {
                    result = Math.Max(result, Math.Abs(A[i]));
                }
            }

            return result;
        }
    }
}
