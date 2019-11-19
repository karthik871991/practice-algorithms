using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice
{
    public class PartitiontoKEqualSumSubsets
    {
        public bool CanPartitionKSubsets(int[] nums, int k)
        {
            var sum = 0;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            if (sum % k != 0)
                return false;

            var sortedSet = new SortedSet<Data>(new DataComparer());

            for (int i = 0; i < k; i++)
            {
                sortedSet.Add(new Data { ID = i });
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                var data = sortedSet.First();

                sortedSet.Remove(data);

                data.Sum += nums[i];
                data.List.Add(nums[i]);

                sortedSet.Add(data);
            }

            if (sortedSet.Select(x => x.Sum).Distinct().Count() == 1)
                return true;

            return false;
        }

        public class DataComparer : IComparer<Data>
        {
            public int Compare(Data x, Data y)
            {
                var d = x.Sum.CompareTo(y.Sum);

                if (d == 0)
                    return x.ID.CompareTo(y.ID);

                return d;
            }
        }

        public class Data
        {
            public List<int> List { get; set; } = new List<int>();
            public int Sum { get; set; }
            public int Position { get; set; }
            public int ID { get; set; }
        }
    }
}