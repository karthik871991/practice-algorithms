using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice.MS
{
    public class MinStepstoMakePilesEqualHeight
    {
        public int MinimumSteps(int[] nums)
        {
            Array.Sort(nums);

            Array.Reverse(nums);

            int result = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] > nums[i])
                    result += i;
            }

            return result;
        }
    }
}
