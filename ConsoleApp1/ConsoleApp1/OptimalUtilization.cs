using System;
using System.Collections.Generic;
using System.Linq;
// background, foreground, less than closest sum

namespace AlgoPractice
{
    public class OptimalUtilization
    {
        public List<List<int>> GetOptimalUtilization(List<List<int>> arr1, List<List<int>> arr2, int target)
        {

            if (arr1.Count < 0 || arr2.Count < 0)
            {
                return new List<List<int>>();
            }

            var list1 = GetGroupedItemsSorted(arr1);
            var list2 = GetGroupedItemsSorted(arr2);

            if (list1.Count == 1 || list2.Count == 1)
            {
                return FindAllPairsStandard(list1, list2, target);
            }

            return FindAllPairs(list1, list2, target);
        }

        private List<List<int>> FindAllPairsStandard(List<Data> list1, List<Data> list2, int target)
        {
            var result = new List<List<int>>();

            var currentMax = int.MinValue;

            foreach (var l1 in list1)
            {
                foreach (var l2 in list2)
                {
                    var sum = l1.Number + l2.Number;

                    if (sum <= target && sum >= currentMax)
                    {
                        if (sum > currentMax)
                        {
                            result = new List<List<int>>();
                        }

                        currentMax = sum;

                        foreach (var l1Id in l1.IDs)
                        {
                            foreach (var l2Id in l2.IDs)
                            {
                                result.Add(new List<int> { l1Id, l2Id });
                            }
                        }
                    }
                }
            }

            return result;
        }

        private List<List<int>> FindAllPairs(List<Data> list1, List<Data> list2, int target)
        {
            var result = new List<List<int>>();
            var currentMax = int.MinValue;

            int l = 0, r = list2.Count - 1;


            while (l < list1.Count && r >= 0)
            {
                var sum = list1[l].Number + list2[r].Number;

                if (sum <= target && sum >= currentMax)
                {
                    if (sum > currentMax)
                    {
                        result = new List<List<int>>();
                    }
                    currentMax = sum;
                    if (list1[l].IDs.Count > 1 || list2[r].IDs.Count > 1)
                    {
                        foreach (var l1Id in list1[l].IDs)
                        {
                            foreach (var l2Id in list2[r].IDs)
                            {
                                result.Add(new List<int> { l1Id, l2Id });
                            }
                        }
                    }
                    else
                    {
                        result.Add(new List<int> { list1[l].IDs.Single(), list2[r].IDs.Single() });
                    }
                    l++;
                }
                else
                {
                    r--;
                }
            }

            //if (l == list1.Count - 1 && r == 0)
            //{
            //    result.AddRange(FindAllPairsStandard(new List<Data> { list1[l - 1] }, new List<Data> { list2[r] }, target));
            //}

            return result;
        }

        private List<Data> GetGroupedItemsSorted(List<List<int>> arr)
        {
            var dict = new Dictionary<int, Data>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (!dict.ContainsKey(arr[i][1]))
                {
                    dict.Add(arr[i][1], new Data { Number = arr[i][1], IDs = new List<int> { arr[i][0] } });
                }
                else
                {
                    dict[arr[i][1]].IDs.Add(arr[i][0]);
                }
            }

            return dict.OrderBy(x => x.Key).ThenBy(y => y.Value.IDs).Select(y => y.Value).ToList();
        }

        public class Data
        {
            public int Number { get; set; }
            public List<int> IDs { get; set; }
        }
    }
}