namespace AlgoPractice
{
    public class NumberOfIslands200
    {
        public int NumIslands(char[,] grid)
        {
            int islandCount = 0;
            for (int i = 0; i <= grid.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= grid.GetUpperBound(1); j++)
                {
                    if (grid[i, j] == '1')
                    {
                        islandCount++;
                        DFS(grid, i, j);
                    }
                }
            }
            return islandCount;
        }

        private void DFS(char[,] grid, int i, int j)
        {
            grid[i, j] = '0';

            if (CheckBoundary(grid, i + 1, j))
                DFS(grid, i + 1, j);

            if (CheckBoundary(grid, i - 1, j))
                DFS(grid, i - 1, j);

            if (CheckBoundary(grid, i, j + 1))
                DFS(grid, i, j + 1);

            if (CheckBoundary(grid, i, j - 1))
                DFS(grid, i, j - 1);
        }

        private bool CheckBoundary(char[,] grid, int i, int j)
        {
            return i <= grid.GetUpperBound(0) && i >= 0
                && j <= grid.GetUpperBound(1) && j >= 0
                && grid[i, j] == '1';
        }
    }
}