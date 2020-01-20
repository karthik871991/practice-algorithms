using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice
{
    public class SubstringsOfSizeKWithKdistinctChars
    {
        public List<string> KSubStrings(string s, int k)
        {
            var set = new HashSet<string>();

            for (int i = 0; i < s.Length - k; i++)
            {
                var subString = s.Substring(i, k);

                if(subString.Length == subString.Distinct().Count())
                {
                    set.Add(subString);
                }
            }

            return set.ToList();
        }
    }
}
