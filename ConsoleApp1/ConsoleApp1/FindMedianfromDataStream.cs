using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice
{
    public class MedianFinder
    {
        public int counter = 0;
        public SortedSet<Data> SetHigh;
        public SortedSet<Data> SetLow;
        public MedianFinder()
        {
            SetHigh = new SortedSet<Data>(Comparer<Data>.Create((a, b) => a.Number == b.Number ? a.Count - b.Count : a.Number - b.Number));
            SetLow = new SortedSet<Data>(Comparer<Data>.Create((a, b) => a.Number == b.Number ? a.Count - b.Count : a.Number - b.Number));
        }

        public void AddNum(int num)
        {
            var data = new Data { Number = num, Count = counter++ };

            SetLow.Add(data);
            SetHigh.Add(SetLow.Last());
            SetLow.Remove(SetLow.Last());

            if(SetLow.Count + 1 < SetHigh.Count)
            {
                SetLow.Add(SetHigh.First());
                SetHigh.Remove(SetHigh.First());
            }
        }

        public double FindMedian()
        {
            if (SetLow.Count == SetHigh.Count)
            {
                return ((double)SetLow.Last().Number + (double)SetHigh.First().Number) / 2;
            }
            else
            {
                return SetLow.Count < SetHigh.Count ? SetHigh.First().Number : 0;
            }
        }

        public class DataComparer : IComparer<Data>
        {
            public int Compare(Data x, Data y)
            {
                var result = x.Number.CompareTo(y.Number);

                if(result == 0)
                {
                    return x.Count.CompareTo(y.Count);
                }

                return result;
            }
        }

        public class Data
        {
            public int Number { get; set; }
            public int Count { get; set; }
        }
    }
}
