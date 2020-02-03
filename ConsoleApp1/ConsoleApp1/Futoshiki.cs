using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice
{
    public class Futoshiki
    {
        string[,] symbol = new string[5, 4]
        {{ "", "<", "", "", },
         { ">", ">", ">", "", },
         { "", "", "", "<", },
         { ">", "", ">", "", },
         { "", "", "", "", }
        };

        Dictionary<string, int> filled = new Dictionary<string, int>();

        public int[,] SolvePuzzle(int[,] input)
        {
            for (int i = 0; i <= input.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= input.GetUpperBound(1); j++)
                {
                    if (input[i, j] > 0)
                        filled.Add(i + "" + j, input[i, j]);
                }
            }

            for (int i = 0; i <= input.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= input.GetUpperBound(1); j++)
                {
                    if (input[i, j] == 0)
                    {
                        var set = new HashSet<string>();
                        var b = DFS(input, i, j, set);
                        if (b)
                            return null;
                    }
                }
            }

            return null;
        }

        private bool DFS(int[,] mat, int i, int j, HashSet<string> set)
        {
            if (!IsInBoundary(mat, i, j))
                return false;

            if (Validate(mat))
            {
                Print(mat);
                Validate(mat);
                return true;
            }
            else
            {
                var nums = GetNumbers(mat, i, j);
                foreach (var num in nums)
                {
                    if (!set.Contains(i + "" + j))
                    {
                        var temp = mat[i, j];

                        if (filled.ContainsKey(i + "" + j))
                            mat[i, j] = filled[i + "" + j];
                        else
                            mat[i, j] = num;

                        set.Add(i + "" + j);
                        var r1 = DFS(mat, i + 1, j, set);
                        if (r1)
                            return true;
                        var r2 = DFS(mat, i - 1, j, set);
                        if (r2)
                            return true;
                        var r3 = DFS(mat, i, j + 1, set);
                        if (r3)
                            return true;
                        var r4 = DFS(mat, i, j - 1, set);
                        if (r4)
                            return true;

                        if (filled.ContainsKey(i + "" + j))
                            mat[i, j] = filled[i + "" + j];
                        else
                            mat[i, j] = temp;

                        set.Remove(i + "" + j);
                    }
                }

                return false;
            }
        }

        private bool IsInBoundary(int[,] mat, int i, int j)
        {
            return i <= mat.GetUpperBound(0) && i >= 0
                && j <= mat.GetUpperBound(1) && j >= 0;
        }

        private List<int> GetNumbers(int[,] mat, int i, int j)
        {
            HashSet<int> set = new HashSet<int>(new List<int> { 1, 2, 3, 4, 5 });
            for (int k = 0; k <= mat.GetUpperBound(0); k++)
            {
                set.Remove(mat[i, k]);
                set.Remove(mat[k, j]);
            }

            return set.ToList();
        }
        int count = 1;
        private void Print(int[,] input)
        {
            Console.WriteLine("-----------" + count);
            ++count;
            for (int i = 0; i <= input.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= input.GetUpperBound(1); j++)
                {
                    Console.Write(input[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public bool Validate(int[,] input)
        {
            var row = new List<int>();
            var col = new List<int>();

            for (int i = 0; i <= input.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= input.GetUpperBound(1); j++)
                {
                    row.Add(input[i, j]);
                    col.Add(input[j, i]);
                }

                if (row.Any(x => x == 0) || col.Any(x => x == 0))
                    return false;

                if (row.Distinct().Count() != row.Count || col.Distinct().Count() != col.Count)
                    return false;

                for (int k = 0; k <= symbol.GetUpperBound(1); k++)
                {
                    if (!Operator(symbol[i, k], row[k], row[k + 1]))
                        return false;
                }

                row = new List<int>();
                col = new List<int>();
            }

            return true;
        }

        public static bool Operator(string logic, int x, int y)
        {
            switch (logic)
            {
                case ">": return x > y;
                case "<": return x < y;
                default: return true;
            }

            throw new System.Exception();
        }

        public class Data
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Value { get; set; }
        }
    }
}