﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgoPractice.MS
{
    public class MaxPossibleValue
    {
        public int MaxValue(int N)
        {
            var map = new SortedDictionary<int, int>();
            var list = new List<string>();
            var arr = new int[5];
            
            var sb = new StringBuilder(Math.Abs(N).ToString());

            var isPositive = N >= 0 ? true : false;

            return isPositive ? HandlePositiveNumber(sb) : HandleNegativeNumber(sb);
        }

        private int HandlePositiveNumber(StringBuilder sb)
        {
            int index = 0;

            while (index < sb.Length && sb[index] - '0' >= 5)
                index++;

            sb.Insert(index, 5);

            return int.Parse(sb.ToString());
        }

        private int HandleNegativeNumber(StringBuilder sb)
        {
            int index = 0;

            while (index < sb.Length && sb[index] - '0' <= 5)
                index++;

            sb.Insert(index, 5);

            return -int.Parse(sb.ToString());
        }
    }
}
