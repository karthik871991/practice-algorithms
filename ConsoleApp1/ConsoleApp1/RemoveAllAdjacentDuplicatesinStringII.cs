using System.Collections.Generic;

namespace AlgoPractice
{
    public class RemoveAllAdjacentDuplicatesinStringII
    {
        public class Data
        {
            public int Count { get; set; }
            public char Character { get; set; }
        }
        public string RemoveDuplicates(string s, int k)
        {
            if (s.Length == 1)
                return s;

            var stack = new Stack<Data>();
            
            int i = 0;
            while (i < s.Length)
            {
                if (stack.Count > 0 && stack.Peek().Character == s[i])
                {
                    stack.Push(new Data { Character = s[i], Count = stack.Peek().Count + 1 });
                }
                else
                {
                    stack.Push(new Data { Character = s[i], Count = 1 });
                }

                if (stack.Peek().Count == k)
                {
                    int temp = k;
                    while (temp > 0)
                    {
                        stack.Pop();
                        temp--;
                    }
                }

                i++;
            }

            var charArr = new char[stack.Count];
            var p = stack.Count - 1;
            while (stack.Count != 0)
            {
                charArr[p--] = stack.Pop().Character;
            }

            return new string(charArr);
        }
    }
}
