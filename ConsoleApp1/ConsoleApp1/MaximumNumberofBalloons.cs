using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractice
{
    public class MaximumNumberofBalloons
    {
        public int MaxNumberOfBalloons(string text)
        {
            var inputMap = new Dictionary<char, int>();
            var input = "balloon";
            for (int i = 0; i < input.Length; i++)
            {
                if (!inputMap.ContainsKey(input[i]))
                {
                    inputMap.Add(input[i], 1);
                }
                else
                {
                    inputMap[input[i]]++;
                }
            }

            var map = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!map.ContainsKey(text[i]))
                {
                    map.Add(text[i], 1);
                }
                else
                {
                    map[text[i]]++;
                }
            }

            foreach (var item in inputMap)
            {
                if(!map.ContainsKey(item.Key) || map[item.Key] < item.Value)
                {
                    return 0;
                }
            }

            return map.Where(x => "balloon".Contains(x.Key)).Min(x => x.Value);
        }
    }
}
