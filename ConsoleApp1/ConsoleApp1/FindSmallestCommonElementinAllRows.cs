using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice
{
    public class FindSmallestCommonElementinAllRows
    {
        public int SmallestCommonElement(int[][] mat)
        {
            if (mat.Length == 0)
                return mat[0][0];

            var map = new Dictionary<int, int>();

            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (map.ContainsKey(mat[i][j]))
                    {
                        map[mat[i][j]] += 1;
                    }
                    else
                    {
                        map.Add(mat[i][j], 0);
                    }
                }
            }

            var list = map.Where(x => x.Value == mat.Length - 1).Select(x => x.Key).OrderBy(x => x);

            if (list == null || !list.Any())
                return -1;

            return list.First();
        }
    }
}