using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractice
{
    public class ReorderLogFiles937
    {
        public string[] ReorderLogFiles(string[] logs)
        {
            var numberList = new List<string>();

            var stringList = new List<Data>();

            foreach (var str in logs)
            {
                var strArr = str.Split(' ');

                //if(char.IsDigit(strArr[1][0]))
                if (int.TryParse(strArr[1], out int n))
                {
                    numberList.Add(str);
                }
                else
                {
                    var data = new Data(strArr, str);
                    stringList.Add(data);
                }
            }

            var sortedStringList = stringList.OrderBy(x => x.Value).ThenBy(x => x.Identifier).Select(x => x.OrginalString).ToList();

            sortedStringList.AddRange(numberList);

            return sortedStringList.ToArray();
        }

        public class Data
        {
            public string Identifier { get; set; }
            public string Value { get; set; }
            public string OrginalString { get; set; }

            public Data(string[] strArr, string str)
            {
                Identifier = strArr[0];
                Value = string.Join(" ", strArr.Skip(1));
                OrginalString = str;
            }
        }
    }
}
