using System.Collections.Generic;

namespace AlgoPractice
{
    public class SubarraySumEqualsK
    {
        public int SubarraySum(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();
            map.Add(0, 1);
            var sum = 0;
            var result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (map.ContainsKey(sum - k))
                {
                    result += map[sum - k];
                }
                if (map.ContainsKey(sum))
                {
                    map[sum]++;
                }
                else
                {
                    map.Add(sum, 1);
                }
            }
            return result;
        }
    }
}