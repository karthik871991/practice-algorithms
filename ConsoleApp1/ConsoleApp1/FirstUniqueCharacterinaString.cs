using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice
{
    public class FirstUniqueCharacterinaString
    {
        public int FirstUniqChar(string s)
        {
            var map = new Dictionary<char, Data>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    map.Add(s[i], new Data { Occurences = 1, Position = i});
                }
                else
                {
                    map[s[i]].Occurences++;
                }
            }

            var result = map.Where(x => x.Value.Occurences == 1).OrderBy(x => x.Value.Position).FirstOrDefault().Value;

            if(result== null)
            {
                return -1;
            }

            return result.Position;
        }

        public class Data
        {
            public int Position { get; set; }
            public int Occurences { get; set; }
        }
    }
}
