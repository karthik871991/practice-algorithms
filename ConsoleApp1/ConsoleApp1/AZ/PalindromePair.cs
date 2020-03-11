using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractice.AZ
{
    public class PalindromePair
    {
        public IList<IList<int>> PalindromePairs(string[] words)
        {
            var map = new Dictionary<string, int>();
            var result = new List<IList<int>>();
            for (int i = 0; i < words.Length; i++)
            {
                var revWord = new string(words[i].Reverse().ToArray());

                if (map.ContainsKey(revWord))
                {
                    result.Add(new List<int> { map[revWord], i });
                }
                else
                {
                    map.Add(words[i], i);
                }
            }

            return result;
        }

        //public static void Main()
        //{
        //    var sut = new PalindromePair().PalindromePairs(new string[] { "abcd", "dcba", "lls", "s", "sssll" });
        //    Assert.AreEqual(7, sut);
        //}
    }
}
