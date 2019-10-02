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
                    return x.GetHashCode().CompareTo(y.GetHashCode());
                }

                return result;
            }
        }

        public int[][] KClosest(int[][] points, int K)
        {
            var lis = new List<DataStructure>(int.MaxValue - 20000);
            var list = new List<DataStructure>();
            var sortedSet = new SortedDictionary<DataStructure,int>(new DataStructureComparer());

            foreach (var input in points)
            {
                var data = new DataStructure();
                data.X = input[0];
                data.Y = input[1];
                data.Distance = Math.Sqrt(Math.Pow(data.X, 2) + Math.Pow(data.Y, 2));

                //list.Add(data);
                if (sortedSet.Count >= K)
                {
                    sortedSet.Add(data,1);
                    sortedSet.Remove(sortedSet.Last().Key);
                }
                else
                {
                    sortedSet.Add(data,1);
                }
            }

            var result = new int[K][];

            for (int i = 0; i < sortedSet.Count; i++)
            {
                //Console.WriteLine($"{set.X}, {set.Y}, {set.Distance}.");

                result[i] = new int[] { sortedSet.ElementAt(i).Key.X, sortedSet.ElementAt(i).Key.Y };
            }
            sortedSet.ToArray();

            //var orderedList = list.OrderBy(x => x.Distance).Take(K).ToList();

            //for (int i=0; i < K; i++)
            //{
            //    result[i] = new int[] { orderedList[i].X, orderedList[i].Y };
            //}

            return result;
        }
    }
}