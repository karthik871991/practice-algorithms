using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice
{
    public class IntegerToEnglish
    {
        int[] Ands = new int[] { 1000000000, 1000000, 1000 };
        string[] AndsValue = new string[] { "Billion", "Million", "Thousand", "Hundred" };
        string[] ones = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                    "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty"};
        string[] tens = new string[] { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        public string NumberToWords(int num)
        {
            if (num == 0)
                return "Zero";

            var sb = new StringBuilder();
            var cur = num;
            for (int i = 0; i < Ands.Length; i++)
            {
                var div = cur / Ands[i];

                if (div > 0)
                {
                    cur = cur % Ands[i];

                    sb.Append(GetValue(div)).Append(" ").Append(AndsValue[i]);
                    if (cur != 0)
                        sb.Append(" ");
                }
            }

            sb.Append(GetValue(cur));

            return sb.ToString();
        }

        private string GetValue(int num)
        {
            var sb = new StringBuilder();
            var d = num / 100;
            if (d > 0)
                sb.Append(ones[d] + " Hundred");

            var r = num % 100;

            if (num > 100 && r != 0)
                sb.Append(" ");

            if (r > 20)
            {
                sb.Append(tens[r / 10]);
                if (r % 10 != 0)
                {
                    sb.Append(" " + ones[r % 10]);
                }
            }
            else
                sb.Append(ones[r]);

            return sb.ToString();
        }
    }
}
