using NUnit.Framework;

namespace AlgoPractice.AZ
{
    public class KthLargestElement
    {
        public int findKthLargest(int[] nums, int k)
        {
            k = nums.Length - k;
            int lo = 0;
            int hi = nums.Length - 1;
            while (lo < hi)
            {
                int j = partition(nums, lo, hi);
                if (j < k)
                {
                    lo = j + 1;
                }
                else if (j > k)
                {
                    hi = j - 1;
                }
                else
                {
                    break;
                }
            }
            return nums[k];
        }

        private int partition(int[] a, int lo, int hi)
        {
            int i = lo;
            int j = hi + 1;
            while (true)
            {
                while (i < hi && less(a[++i], a[lo])) ;
                while (j > lo && less(a[lo], a[--j])) ;
                if (i >= j)
                {
                    break;
                }
                exch(a, i, j);
            }
            exch(a, lo, j);
            return j;
        }

        private void exch(int[] a, int i, int j)
        {
            int tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }

        private bool less(int v, int w)
        {
            return v < w;
        }

        //public static void Main()
        //{
        //    var s = (10 / 2 * 5);
        //    var sut = new KthLargestElement().findKthLargest(new int[] { 6, 8, 3, 4, 9, 1, 2, 7, 5 }, 3);
        //    Assert.AreEqual(7, sut);
        //}
    }
}
