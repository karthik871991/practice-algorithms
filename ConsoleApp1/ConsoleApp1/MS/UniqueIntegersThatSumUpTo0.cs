using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice.MS
{
    public class UniqueIntegersThatSumUpTo0
    {
        public int[] UniqueIntegers(int N)
        {
            var list = new List<int>();

            if (N % 2 != 0)
                list.Add(0);

            for (int i = 1; i <= (N / 2); i++)
            {
                list.Add(i);
                list.Add(-i);
            }

            return list.ToArray();
        }
    }
}
