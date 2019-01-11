using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice
{
    public class UniqueEmailAddresses
    {
        public int NumUniqueEmails(string[] emails)
        {
            var hs = new HashSet<string>();

            foreach (var str in emails)
            {
                var strspts = str.Split('@');
                var name = strspts[0];

                var pluses = name.Split('+');

                var word = pluses[0].Replace(".", "");

                hs.Add(word + strspts[1]);
            }

            return hs.Count;

        }
    }
}
