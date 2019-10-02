using System;
using System.Collections.Generic;

namespace AlgoPractice
{
    public class FindAllDuplicatesinanArray
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            var result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[Math.Abs(nums[i]) - 1] < 0)
                {
                    result.Add(Math.Abs(nums[i]));
                }
                else
                {
                    nums[Math.Abs(nums[i]) - 1] = -nums[Math.Abs(nums[i]) - 1];
                }
            }

            return result;
        }
    }
}

//Given an array of integers, 1 ≤ a[i] ≤ n(n = size of array), some elements appear twice and others appear once.

//Find all the elements that appear twice in this array.

//Could you do it without extra space and in O(n) runtime?


//Example:
//Input:
//[4,3,2,7,8,2,3,1]

//Output:
//[2,3]
