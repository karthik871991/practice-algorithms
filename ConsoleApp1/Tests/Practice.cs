using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    [TestClass]
    public class Practice
    {
        [TestMethod]
        public void Test()
        {
            var a = new Sample { foo = 1, moo = 3 };
            var b = new Sample { foo = 2, moo = 2 };
            var c = new Sample { foo = 3, moo = 1 };
            var d = new Sample { foo = 4, moo = 2 };
            var e = new Sample { foo = 1, moo = 1 };
            var f = new Sample { foo = 2, moo = 1 };
            var g = new Sample { foo = 4, moo = 1 };
            var h = new Sample { foo = 4, moo = 1 };

            var list = new List<Sample> { a, b, c, d, e, f, g };

            var sort = list.OrderBy(x => x.foo).ThenBy(y => y.moo);

            var map = new Dictionary<int, int>();

            var sortSet = new SortedSet<Sample>(new DuplicateKeyComparer());

            var sortedDict = new SortedDictionary<Sample, Sample>(new DuplicateKeyComparer());

            var sd = new SortedDictionary<Example, Example>(new ComparerExample());
            sd.Add(new Example { MyProperty = 1 }, new Example());
            sd.Add(new Example { MyProperty = 1 }, new Example());

            var dict = new Dictionary<string, string>();

            var hash = new HashSet<string>();

            foreach (var l in list)
            {
                sortSet.Add(l);
                sortedDict.Add(l, l);
            }
        }

        public class Example
        {
            public int MyProperty { get; set; }
        }

        public class ComparerExample : IComparer<Example>
        {
            public int Compare(Example x, Example y)
            {
                int result = x.MyProperty.CompareTo(y.MyProperty);
                if(result == 0)
                {
                    return x.GetHashCode().CompareTo(y.GetHashCode());
                }

                return result;
            }
        }

        public class DuplicateKeyComparer : IComparer<Sample>
        {

            public int Compare(Sample x, Sample y)
            {
                int result = x.foo.CompareTo(y.foo);

                if (result == 0)
                {
                    if (x.moo.CompareTo(y.moo) == 0)
                    {
                        return x.GetHashCode().CompareTo(y.GetHashCode());
                    }
                    return x.moo.CompareTo(y.moo);   // Handle equality as beeing greater
                }

                else
                    return result;
            }
        }

        public class Sample
        {
            public int foo { get; set; }
            public int moo { get; set; }
        }
    }
}