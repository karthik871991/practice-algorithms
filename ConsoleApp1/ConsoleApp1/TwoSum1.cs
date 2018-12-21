using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice
{
    public class TwoSum1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[] { dict[target - nums[i]], i };
                }
                else
                {
                    if (!dict.ContainsKey(nums[i]))
                        dict.Add(nums[i], i);
                }
            }

            return null;
        }
    }
}