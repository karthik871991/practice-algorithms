using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice
{
    public class CustomTwoSum
    {
        public List<int> TwoSum(List<int> nums, int target)
        {
            var dict = new Dictionary<int, int>();
            var temp = new int[2];
            int max = int.MinValue;
            for (int i = 0; i < nums.Count; i++)
            {
                if(dict.ContainsKey(nums[i]))
                {
                    if(nums[i] > max || nums[dict[nums[i]]] > max)
                    {
                        temp[0] = dict[nums[i]];
                        temp[1] = i;
                        max = Math.Max(nums[i], dict[nums[i]]);
                    }
                }
                dict[target - nums[i]] = i;
            }

            return temp.ToList();
        }
    }
}