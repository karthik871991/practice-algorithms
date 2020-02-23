using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractice
{
    public class OrangesRotting
    {
        public int RottingOranges(int[][] grid)
        {
            var set = new HashSet<Position>(new EqalityComparer());
            var q = new Queue<Position>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        var position = new Position { X = i, Y = j };
                        set.Add(position);
                        q.Enqueue(position);
                    }
                }
            }

            var minutes = 1;

            while (q.Any())
            {
                var size = q.Count;
                for (int i = 0; i < size; i++)
                {
                    var cur = q.Dequeue();

                    if (set.Add(new Position { X = cur.X + 1, Y = cur.Y }) && cur.X + 1 < grid.Length && grid[cur.X+1][cur.Y] == 1)
                        q.Enqueue(new Position { X = cur.X + 1, Y = cur.Y });
                    if (set.Add(new Position { X = cur.X - 1, Y = cur.Y }) && cur.X - 1 >= 0 && grid[cur.X - 1][cur.Y] == 1)
                        q.Enqueue(new Position { X = cur.X - 1, Y = cur.Y });
                    if (set.Add(new Position { X = cur.X, Y = cur.Y + 1 }) && cur.Y + 1 < grid[cur.X].Length && grid[cur.X][cur.Y + 1] == 1)
                        q.Enqueue(new Position { X = cur.X, Y = cur.Y + 1 });
                    if (set.Add(new Position { X = cur.X, Y = cur.Y - 1 }) && cur.Y - 1 >= 0 && grid[cur.X][cur.Y - 1] == 1)
                        q.Enqueue(new Position { X = cur.X, Y = cur.Y - 1 });

                }
                ++minutes;
            }



            return minutes;
        }



        public class EqalityComparer : IEqualityComparer<Position>
        {
            public bool Equals(Position x, Position y)
            {
                return x.X == y.X && x.Y == y.Y;
            }

            public int GetHashCode(Position obj)
            {
                return HashCode.Combine(obj.X, obj.Y);
            }
        }

        public class Position
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
