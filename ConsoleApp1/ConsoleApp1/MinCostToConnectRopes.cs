using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractice
{
    public class MinCostToConnectRopes
    {
        public int MinCost(List<int> ropes)
        {
            if (ropes.Count == 1)
                return 0;

            var set = new SortedSet<Data>(new IntComparer());

            foreach (var number in ropes)
            {
                var data = new Data { Number = number };
                set.Add(data);
            }

            var result = 0;

            while (set.Count != 0)
            {
                if (set.Count == 1)
                {
                    result += set.First().Number;
                    set.Remove(set.First());
                    continue;
                }

                var one = set.First().Number;
                set.Remove(set.First());
                var two = set.First().Number;
                set.Remove(set.First());

                var newNumber = one + two;
                result += newNumber;

                if (set.Count > 0)
                {
                    var data = new Data { Number = newNumber };
                    set.Add(data);
                }
            }

            return result;
        }

        public class Data
        {
            public int Number { get; set; }
        }

        internal class IntComparer : IComparer<Data>
        {
            public int Compare(Data a, Data b)
            {
                var result = a.Number.CompareTo(b.Number);

                if (result != 0)
                    return result;
                else
                    return a.GetHashCode().CompareTo(b.GetHashCode());
            }
        }
    }
}
