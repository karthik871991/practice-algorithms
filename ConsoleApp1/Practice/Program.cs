using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Practice
{
    class Solution
    {
        public class Data
        {
            public int A { get; set; }
            public int B { get; set; }

            public int GetA()
            {
                return A;
            }
        }

        static void Main(string[] args)
        {
            var l = new LinkedList<string>();

            lock (l)
            {

            }

            var list = new LinkedList<string>();
            var random = new Random().NextDouble();
            var db = new List<Data> { new Data { A = 1, B = 1 }, new Data { A = 2, B = 2 }, new Data { A = 3, B = 3 } };
            var local = new List<Data> { new Data { A = 1, B = 1 }, new Data { A = 2, B = 2 }, new Data { A = 0, B = 0 } };

            var d = new Data { A = 5, B = 5 }
;
            var str = JsonConvert.SerializeObject(d);
            Console.WriteLine("Complete");
            
            var union = local.Union(db, new DataComparer()).ToList();

            var intersect = local.Intersect(db, new DataComparer()).ToList();

            var updates = union.Except(intersect, new DataComparer()).ToList();

            var sameIds = updates.GroupBy(x => x.A);
        }


        public class DataComparer : IEqualityComparer<Data>
        {
            public bool Equals(Data x, Data y)
            {
                return x.A == y.A && x.B == y.B;
            }

            public int GetHashCode(Data obj)
            {
                return 0;
            }
        }
    }
}