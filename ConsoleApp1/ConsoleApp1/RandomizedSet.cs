using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice
{
    public class RandomizedSet
    {
        private List<int> arr;
        private Dictionary<int, int> map;
        public RandomizedSet()
        {
            arr = new List<int>();
            map = new Dictionary<int, int>();
        }

        public bool Insert(int val)
        {
            if (!map.ContainsKey(val))
            {
                arr.Add(val);
                map.Add(val, arr.Count - 1);

                return true;
            }

            return false;
        }

        public bool Remove(int val)
        {
            if (!map.ContainsKey(val))
                return false;

            var pos1 = map[val];
            var pos2 = arr.Count - 1;

            map[arr[arr.Count - 1]] = map[val];

            Swap(pos1, pos2);

            arr.RemoveAt(arr.Count - 1);
            map.Remove(val);

            return true;
        }

        private void Swap(int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public int GetRandom()
        {
            var rnumber = new Random().Next(0, arr.Count);

            return arr[rnumber];
        }
    }
}