using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice
{
    public class KClosestPointsToOrgin973
    {
        public class DataStructure
        {
            public int X { get; set; }
            public int Y { get; set; }
            public double Distance { get; set; }
        }

        public class DataStructureComparer : IComparer<DataStructure>
        {
            public int Compare(DataStructure x, DataStructure y)
            {
                var result = x.Distance.CompareTo(y.Distance);
                if (result == 0)
                {
                    return x.X.CompareTo(y.X);
                }

                return result;
            }
        }

        public int[][] KClosest(int[][] points, int K)
        {

            var sortedSet = new SortedSet<DataStructure>(new DataStructureComparer());

            foreach (var input in points)
            {
                var data = new DataStructure();
                data.X = input[0];
                data.Y = input[1];
                data.Distance = Math.Sqrt(Math.Pow(data.X, 2) + Math.Pow(data.Y, 2));

                if (sortedSet.Count >= K)
                {
                    sortedSet.Add(data);
                    sortedSet.Remove(sortedSet.Last());
                }
                else
                {
                    sortedSet.Add(data);
                }
            }

            var result = new int[K][];

            for (int i = 0; i < sortedSet.Count; i++)
            {
                //Console.WriteLine($"{set.X}, {set.Y}, {set.Distance}.");

                result[i] = new int[] { sortedSet.ElementAt(i).X, sortedSet.ElementAt(i).Y };
            }
            sortedSet.ToArray();
            return result;
        }
    }
}