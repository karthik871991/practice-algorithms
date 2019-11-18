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
        public Solution()
        {

        }

        public class Data
        {
            public int A { get; set; }
            public int B { get; set; }

            public async Task<int> DoWork()
            {
                Console.WriteLine("inside dowork");
                await Task.WhenAll();
                return 1;
            }

            public async Task<int> DoNetworkCall()
            {
                Console.WriteLine("network call");

                return 1;
            }
        }

        static void Main(string[] args)
        {
            var db = new List<Data> { new Data { A = 1, B = 1 }, new Data { A = 3, B = 1 } };
            var local = new List<Data> { new Data { A = 1, B = 2 }, new Data { A = 2, B = 2 } };
            var count = 0;
            db.ToList().ForEach(async x => await x.DoWork());

            Console.WriteLine("Complete");

            db.ToList().ForEach(async x => await x.DoWork());

            Console.WriteLine("Complete");
            
            var merged = local.Intersect(db);//, new DataComparer());
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