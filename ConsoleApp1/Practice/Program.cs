using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Solution
    {
        public Solution()
        {

        }

        public class Data
        {
            public int A { get; set; }
            public int B { get; set; }
            public int ID { get; set; }
        }

        static void Main(string[] args)
        {
            var db = new List<Data> { new Data { A = 1, B = 2, ID = 123 }, new Data { A = 3, B = 4, ID = 234 } };
            var local = new List<Data> { new Data { A = 1, B = 5, ID = 123 }, new Data { A = 2, B = 6, ID = 234 } };

            var merged = local.Union(db, new DataComparer());
        }

        public class DataComparer : IEqualityComparer<Data>
        {
            public new bool Equals(Data x, Data y)
            {
                if (ReferenceEquals(x, y))
                    return true;

                return x.A == y.A;
            }

            public int GetHashCode(Data obj)
            {
                return obj.A.GetHashCode();
            }
        }
    }
}