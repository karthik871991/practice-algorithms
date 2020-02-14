using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractice.Office
{
    public class Waps
    {
        //public static void Main(string[] args)
        //{
        //    var grid = new int[3][]
        //    {
        //        new int[3] { 0, 0, 0 },
        //        new int[3] { 0, 0, 0 },
        //        new int[3] { 0, 0, 0 }
        //    };

        //    Print(grid);
        //}
        public static void Print(int[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {

                }
            }
        }

        private void DFS(int[][] grid)
        {

        }

        public static bool IsValid(int[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0)
                        return false;

                    if (i != 0 && j != 0 && grid[i][j] == 0 && grid[i - 1][j] != grid[i][j] && grid[i][j - 1] != grid[i][j])
                        return false;
                }
            }

            return true;
        }
    }
}
