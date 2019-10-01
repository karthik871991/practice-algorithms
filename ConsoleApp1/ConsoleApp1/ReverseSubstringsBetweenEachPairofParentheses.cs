using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractice
{
    public class ReverseSubstringsBetweenEachPairofParentheses
    {
        public string ReverseParentheses(string s)
        {
            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == ')')
                {
                    var temp = new Queue<char>();

                    while(stack.Peek() != '(')
                    {
                        temp.Enqueue(stack.Pop());
                    }

                    stack.Pop();
                    while (temp.Any())
                    {
                        stack.Push(temp.Dequeue());
                    }
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            var sb = new StringBuilder();

            while (stack.Any())
            {
                sb.Append(stack.Pop());
            }
            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
