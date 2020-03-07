using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice.MS
{
    public class PlaneReservation
    {
        public static void Main(string[] args)
        {
            //var result = solution(2, "1A 2F 1C");

            //var re = new PlaneReservation().solution(new int[] { 7 });
            //re = new PlaneReservation().solution(new int[] { 4, 3 });
            //re = new PlaneReservation().solution(new int[] { 11, 1, 8, 12, 14 });
            //re = new PlaneReservation().solution(new int[] { 4, 10, 8, 5, 9 });
            //re = new PlaneReservation().solution(new int[] { 5, 5, 5, 5, 5 });
            //re = new PlaneReservation().solution(new int[] { 1, 2, 3, 3 });

            var res = new PlaneReservation().solution(2, 4);
            res = new PlaneReservation().solution(3, 20);
            res = new PlaneReservation().solution(5, 6);
            res = new PlaneReservation().solution(2, 1);
            res = new PlaneReservation().solution(5, 3);
        }

        public String[] solution(int N, int K)
        {
            if (N == 0)
            {
                return new String[] { "" };
            }
            var result = new List<String>();
            foreach (String p in solution(N - 1, K))
            {
                foreach (char l in new char[] { 'a', 'b', 'c' })
                {
                    int pLen = p.Length;
                    if (pLen == 0 || p[pLen - 1] != l)
                    {
                        result.Add(p + l);
                    }
                }
            }
            int prefSize = Math.Min(result.Count, K);

            var list = result.GetRange(0, prefSize);
            return list.ToArray();
        }

        public int solution(int[] A, int[] B)
        {
            var totalSumA = 0;
            var totalSumB = 0;

            for (int i = 0; i < A.Length; i++)
            {
                totalSumA += A[i];
                totalSumB += B[i];
            }

            var leftSum = 0;
            var rightSum = 0;

            var totalWays = 0;

            for (int i = 0; i < A.Length - 1; i++)
            {
                leftSum += A[i];
                rightSum += B[i];

                if (totalSumA == 2 * leftSum && totalSumB == 2 * rightSum && leftSum == rightSum)
                    totalWays++;
            }

            return totalWays;
        }

        public bool solution(int[] A)
        {
            var set = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (set.Contains(A[i] + 1) || set.Contains(A[i] - 1))
                    return true;

                set.Add(A[i]);
            }

            return false;
        }

        public static int solution(int N, string S)
        {
            int res = 0;
            var strs = S.Split(" ");
            var map = new Dictionary<int, HashSet<char>>();
            for (int i = 1; i <= N; i++)
            {
                map.Add(i, new HashSet<char>());
            }

            foreach (var str in strs)
            {
                map[int.Parse(str.Substring(0, str.Length - 1))].Add(str[str.Length - 1]);
            }

            foreach (var entry in map.Keys)
            {
                var rowCount = 0;
                var set = map[entry];
                if (set.Add('B') && set.Add('C') && set.Add('D') && set.Add('E'))
                {
                    rowCount++;
                    //res++;
                    //set.Add(Arrays.asList('B', 'C', 'D', 'E');
                }

                if (set.Add('F') && set.Add('G') && set.Add('H') && set.Add('J'))
                {
                    rowCount++;
                    //res++;
                    //set.addAll(Arrays.asList('F', 'G', 'H', 'J'));
                }

                if (rowCount != 2 && set.Add('D') && set.Add('E') && set.Add('F') && set.Add('G'))
                {
                    rowCount++;
                    //res++;
                    //set.addAll(Arrays.asList('D', 'E', 'F', 'G'));
                }

                res += rowCount;
            }

            return res;
        }
    }
}
