using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice
{
    public class LetterCombination
    {
        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();
            var map = new Dictionary<int, string>();
            map.Add(2, "abc");
            map.Add(3, "def");
            map.Add(4, "ghi");
            map.Add(5, "jkl");
            map.Add(6, "mno");
            map.Add(7, "pqrs");
            map.Add(8, "tuv");
            map.Add(9, "wxyz");
            Recursion(result, "", digits, map, 0);
            return result;
        }

        private void Recursion(List<string> list, string str, string digits, Dictionary<int, string> map, int index)
        {
            if (str.Length == digits.Length)
            {
                list.Add(str);
                return;
            }

            var ch = digits[index] - '0';
            for (int j = 0; j < map[ch].Length; j++)
            {
                Recursion(list, str + map[ch][j], digits, map, index + 1);
            }
        }

        //public static void Main(string[] args)
        //{
        //    var sut = new LetterCombination();
        //    var list = sut.LetterCombinations("234");
        //    Console.WriteLine(string.Join(",", list));
        //    Console.ReadLine();
        //}
    }
}
