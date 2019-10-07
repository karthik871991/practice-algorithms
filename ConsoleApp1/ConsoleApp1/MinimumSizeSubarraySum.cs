using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice
{
    public class MinimumSizeSubarraySum
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            int max = int.MaxValue;
            int j = 0;
            int sum = 0;

            for (int i = 0; i < nums.Length;)
            {
                sum += nums[i++];

                while (sum >= s)
                {
                    max = Math.Min(max, i - j);
                    sum -= nums[j++];
                }
                
            }

            if (max == int.MaxValue)
            {
                return 0;
            }

            return max;
        }
    }
}
