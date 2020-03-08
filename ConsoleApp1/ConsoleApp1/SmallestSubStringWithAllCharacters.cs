using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice
{
    public class SmallestSubStringWithAllCharacters
    {
        public string FindSmallestSubString(string s, string t)
        {
            var set = new HashSet<char>(s);
            var map = new Dictionary<char, int>();

            int x = 0;
            int pre = int.MaxValue;
            string result = "";
            string nresult = "";
            for (int i = 0; i < t.Length; i++)
            {
                if (!map.ContainsKey(t[i]))
                    map.Add(t[i], 0);

                map[t[i]]++;

                if (map.Count == set.Count)
                {
                    while (map.Count == set.Count)
                    {
                        if (pre > i - x)
                        {
                            pre = i - x + 1;
                            result = t.Substring(x, i - x + 1);
                        }
                        map[t[x]]--;

                        if (map[t[x]] == 0)
                        {
                            map.Remove(t[x]);
                        }
                        x++;
                    }
                    nresult = t.Substring(x - 1, i - x + 2);

                }


            }

            return nresult;
        }


        //public static void Main(string[] args)
        //{
        //    var sut = new SmallestSubStringWithAllCharacters();
        //    var str = sut.FindSmallestSubString("xyz", "xyyzzyx");

        //    Console.WriteLine(str);

        //    str = sut.FindSmallestSubString("abcde", "abcdee");
        //    Console.WriteLine(str);

        //    str = sut.FindSmallestSubString("abcd", "aabbccdd");
        //    Console.WriteLine(str);

        //    str = sut.FindSmallestSubString("a", "a");
        //    Console.WriteLine(str);
        //    Console.ReadLine();
        //}
    }
}
