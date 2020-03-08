using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractice.AZ
{
    public class ShortestDistanceFromAllBuildings
    {
        int[] dx = { 1, 0, -1, 0 }, dy = { 0, 1, 0, -1 };

        public int ShortestDistance(int[][] grid)
        {
            int m = grid.Length, n = grid[0].Length;
            int[,] dist = new int[m, n];

            List<Tuple> buildings = new List<Tuple>();
            for (int i = 0; i < m; ++i)
                for (int j = 0; j < n; ++j)
                {
                    if (grid[i][j] == 1)
                        buildings.Add(new Tuple(i, j, 0));
                    grid[i][j] = -grid[i][j];
                }

            for (int k = 0; k < buildings.Count; ++k)
            {
                bfs(buildings[k], k, dist, grid, m, n);
                Print(grid);
                Print(dist);
            }

            int ans = -1;
            for (int i = 0; i < m; ++i)
                for (int j = 0; j < n; ++j)
                    if (grid[i][j] == buildings.Count && (ans < 0 || dist[i, j] < ans))
                        ans = dist[i, j];
            return ans;
        }
        private void Print(int[][] grid)
        {
            for (int i = 0; i < grid.Length; ++i)
            {
                for (int j = 0; j < grid[0].Length; ++j)
                    Console.Write(grid[i][j] + " , ");

                Console.WriteLine();
            }
        }

        private void Print(int[,] dist)
        {
            for (int i = 0; i <= dist.GetUpperBound(0); ++i)
            {
                for (int j = 0; j <= dist.GetUpperBound(1); ++j)
                    Console.Write(dist[i,j] + " , ");

                Console.WriteLine();
            }
        }
        public void bfs(Tuple root, int k, int[,] dist, int[][] grid, int m, int n)
        {
            Queue<Tuple> q = new Queue<Tuple>();
            q.Enqueue(root);
            while (q.Any())
            {
                Tuple b = q.Dequeue();
                dist[b.y, b.x] += b.dist;
                for (int i = 0; i < 4; ++i)
                {
                    int x = b.x + dx[i], y = b.y + dy[i];
                    if (y >= 0 && x >= 0 && y < m && x < n && grid[y][x] == k)
                    {
                        grid[y][x] = k + 1;
                        q.Enqueue(new Tuple(y, x, b.dist + 1));
                    }
                }
            }
        }
        public class Tuple
        {
            public int y;
            public int x;
            public int dist;

            public Tuple(int y, int x, int dist)
            {
                this.y = y;
                this.x = x;
                this.dist = dist;
            }
        }

        //public static void Main()
        //{
        //    var grid = new int[3][]; //[[1,0,2,0,1],[0,0,0,0,0],[0,0,1,0,0]]
        //    grid[0] = new int[] { 1, 0, 2, 0, 1 };
        //    grid[1] = new int[] { 0, 0, 0, 0, 0 };
        //    grid[2] = new int[] { 0, 0, 1, 0, 0 };

        //    var sut = new ShortestDistanceFromAllBuildings().ShortestDistance(grid);
        //    Assert.AreEqual(7, sut);
        //}
    }
}
