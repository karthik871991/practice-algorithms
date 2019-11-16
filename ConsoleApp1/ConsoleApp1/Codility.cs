using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractice
{
    public class Codility
    {
        public long pthFactor(long n, long p)
        {
            List<long> factors = new List<long>();
            int max = (int)Math.Sqrt(n);  //round down
            for (int factor = 1; factor <= max; ++factor)
            { //test from 1 to the square root, or the int below it, inclusive.
                if (n % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != n / factor)
                    { // Don't add the square root twice!  Thanks Jon
                        factors.Add(n / factor);
                    }
                }
            }
            var ss = factors.OrderBy(x => x).ToList();
            long c = 0;
            foreach (var i in ss)
            {
                c++;
                if (c == p)
                    return i;
            }

            return 0;
        }
        //public static long pthFactor(long n, long p)
        //{
        //    long count = 1;
        //    var allFactors = new List<long>();
        //    long lNumber = (long)Math.Sqrt(n);
        //    for (long i = 1; i <= lNumber; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            count++;
        //            if (count == p)
        //            {
        //                return n / i;
        //            }
        //        }
        //    }

        //    var list = allFactors.OrderBy(x => x).ToList();

        //    if (list.Count - 1 > p)
        //    {
        //        return list[(int)p];
        //        for (int i = 0; i < p; i++)
        //        {

        //        }
        //    }

        //    return 0;
        //}

        public static int maxLength(List<int> a, int k)
        {
            int sum = 0;
            int count = 0;
            int max = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if ((sum + a[i]) <= k)
                {
                    sum += a[i];
                    count++;
                }

                else if (sum != 0)
                {
                    sum = sum - a[i - count] + a[i];
                }

                max = Math.Max(count, max);
            }
            return max;
        }

        static List<long> printDistSum(long[] arr, long n)
        {
            long sum = 0;
            for (long i = 0; i < n; i++)
                sum += arr[i];

            bool[,] dp = new bool[n + 1, sum + 1];

            for (long i = 0; i <= n; i++)
                dp[i, 0] = true;

            for (long i = 1; i <= n; i++)
            {
                dp[i, arr[i - 1]] = true;
                for (long j = 1; j <= sum; j++)
                {
                    if (dp[i - 1, j] == true)
                    {
                        dp[i, j] = true;
                        dp[i, j + arr[i - 1]] = true;
                    }
                }
            }

            var result = new List<long>();
            for (long j = 0; j <= sum; j++)
                if (dp[n, j] == true)
                {
                    Console.Write(j + " ");
                    result.Add(j);
                }

            return result;
        }

        public static long maxSum(List<long> arr, long threshold)
        {
            var list = printDistSum(arr.OrderBy(x => x).ToArray(), arr.Count);

            long pre = 0;

            foreach (var item in list)
            {
                if (item > threshold)
                {
                    return pre;
                }
                pre = item;
            }
            return pre;
        }
    }
}
