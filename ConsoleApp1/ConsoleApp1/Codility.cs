using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractice
{
    public class Codility
    {
        public int solution(int[] T)
        {
            var list = T.ToList();

            var dist = list.Distinct();

            if (dist.Count() >= (T.Length / 2))
                return T.Length / 2;
            else
                return dist.Count();
        }
    }
}
