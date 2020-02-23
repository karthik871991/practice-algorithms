using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractice
{
    public class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var cur = new List<int>();
            var result = new List<IList<int>>();
            Recursion(result, cur, nums);
            return result;
        }

        private void Recursion(IList<IList<int>> result, IList<int> cur, int[] nums)
        {
            if (cur.Count == nums.Length)
            {
                result.Add(cur.ToList());
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    //if (cur.Contains(nums[i])) continue;
                    cur.Add(nums[i]);
                    Recursion(result, cur, nums);
                    cur.Remove(nums[i]);
                }
            }
        }

        //public static void Main(string[] args)
        //{
        //    var sut = new Permutations();
        //    var list = sut.Permute(new int[] { 1, 2, 3 });
        //    foreach (var item in list)
        //    {
        //        Console.Write(string.Join(",", item));
        //        Console.WriteLine();
        //    }
        //    Console.ReadLine();
        //}
    }
}
