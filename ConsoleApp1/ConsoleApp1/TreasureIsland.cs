using System.Collections.Generic;

namespace AlgoPractice
{
    public class TreasureIsland
    {
        public int MinSteps(char[, ] grid)
        {
            var q = new Queue<Data>();

            var set = new HashSet<string>();

            q.Enqueue(new Data { X = 0, Y = 0, Distance = 0 });
            set.Add(0 + "," + 0);

            while(q.Count != 0)
            {
                var data = q.Dequeue();
                
                if (grid[data.X, data.Y] == 'X')
                    return data.Distance;

                foreach (var point in GetNextPoints(data.X, data.Y, grid))
                {
                    if(!set.Contains(point[0] + "," + point[1]) && grid[point[0], point[1]] != 'D')
                    {
                        set.Add(data.X + "," + data.Y);
                        q.Enqueue(new Data { X = point[0], Y = point[1], Distance = data.Distance + 1 });
                    }
                }
            }

            return 0;
        }

        public List<int[]> GetNextPoints(int x, int y, char[, ] grid)
        {
            var list = new List<int[]>();

            if (CheckBoundary(x + 1, y, grid))
                list.Add(new int []{ x + 1, y });

            if (CheckBoundary(x - 1, y, grid))
                list.Add(new int[] { x - 1, y });

            if (CheckBoundary(x, y + 1, grid))
                list.Add(new int[] { x, y + 1 });

            if (CheckBoundary(x, y - 1, grid))
                list.Add(new int[] { x, y - 1 });

            return list;
        }

        private bool CheckBoundary(int x, int y, char[, ] grid)
        {
            if (x >= 0 && x <= grid.GetUpperBound(0) && y >= 0 && y <= grid.GetUpperBound(1))
                return true;

            return false;
        }

        public class Data
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Distance { get; set; }
        }
    }
}