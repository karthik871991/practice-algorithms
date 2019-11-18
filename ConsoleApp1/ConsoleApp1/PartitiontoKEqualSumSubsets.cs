using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice
{
    public class PartitiontoKEqualSumSubsets
    {
        public bool CanPartitionKSubsets(int[] nums, int k)
        {            
            var total = 0;
            var map = new Dictionary<int, int>();

            var list = new List<Data>();

            foreach (var item in nums)
            {
                total += item;
                if (!map.ContainsKey(item))
                {
                    map.Add(item, 1);
                }
                else
                {
                    map[item]++;
                }
            }

            if (total % k != 0)
                return false;

            foreach (var item in map)
            {
                list.Add(new Data { Number = item.Key, Count = item.Value });
            }

            var ordList = list.OrderBy(x => x.Number).ToList();

            for (int i = 0; i < k; i++)
            {
                var groupTotal = total / k;

                int j = ordList.Count - 1;

                while (j >= 0)
                {
                    while (ordList[j].Count > 0 && ordList[j].Number <= groupTotal)
                    {
                        groupTotal -= ordList[j].Number;
                        ordList[j].Count--;
                    }

                    j--;
                }

                if (groupTotal > 0)
                    return false;
            }

            return true;
        }

        public class Data
        {
            //public int Index { get; set; }
            public int Number { get; set; }
            public int Count { get; set; }
        }
    }
}