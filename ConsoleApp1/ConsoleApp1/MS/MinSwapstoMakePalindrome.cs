using System.Collections.Generic;

namespace AlgoPractice.MS
{
    public class MinSwapstoMakePalindrome
    {
        public int MinSwaps(string str)
        {
            if (string.IsNullOrWhiteSpace(str) || str.Length == 1)
                return 0;

            var strArr = str.ToCharArray();
            var count = 0;
            if (CanBePalindrome(str))
            {
                int i = 0;
                int j = strArr.Length - 1;

                while (i < j)
                {
                    if (strArr[i] == strArr[j])
                    {
                        i++;
                        j--;
                        continue;
                    }

                    if (strArr[i] != strArr[j])
                    {
                        int k = j;

                        while (k > i && strArr[k] != strArr[i])
                            k--;

                        if (k != i)
                        {
                            for (; k < j; k++)
                            {
                                Swap(k, k + 1, strArr);
                                count++;
                            }

                            i++;
                            j--;
                        }
                        else
                        {
                            Swap(i, i + 1, strArr);
                            count++;
                        }
                    }
                }

                return count;
            }

            return -1;
        }

        private void Swap(int i, int j, char[] strArr)
        {
            var temp = strArr[i];
            strArr[i] = strArr[j];
            strArr[j] = temp;
        }

        public bool CanBePalindrome(string str)
        {
            if (string.IsNullOrWhiteSpace(str) || str.Length == 1)
                return true;

            var set = new HashSet<char>();

            foreach (var c in str)
            {
                if (set.Contains(c))
                    set.Remove(c);
                else
                    set.Add(c);
            }

            return set.Count == 0 || set.Count == 1;
        }
    }
}
