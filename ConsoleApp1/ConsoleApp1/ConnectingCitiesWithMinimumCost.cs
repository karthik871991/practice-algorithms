using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice
{
    public class ConnectingCitiesWithMinimumCost
    {
        public class Data
        {
            public int City { get; set; }
            public int Cost { get; set; }
        }

        public class DataComparer : IComparer<Data>
        {
            public int Compare(Data x, Data y)
            {
                return x.Cost.CompareTo(y.Cost);
            }
        }
        public int MinimumCost(int N, int[][] connections)
        {
            //var graph = new SortedDictionary<int, Data>(new DataComparer());


            return 0;
        }


    }
}
