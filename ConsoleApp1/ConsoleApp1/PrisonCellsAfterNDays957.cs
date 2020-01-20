using System.Collections.Generic;
using System.Text;

namespace AlgoPractice
{
    public class PrisonCellsAfterNDays
    {
        public int[] PrisonAfterNDays(int[] cells, int N)
        {
            var map = new Dictionary<string, int[]>();

            var cellsCopy = new int[cells.Length];

            cells.CopyTo(cellsCopy,0);


            for (int i = 0; i < N; i++)
            {
                if(i > 12)
                {

                }

                if (map.ContainsKey(GetString(cells)))
                {
                    var number = (N % map.Count);
                    cells = cellsCopy;
                    N = number;
                    i = 0;
                    map.Clear();
                }

                map.Add(GetString(cells), cells);

                int p = cells[0];

                for (int j = 1; j <= cells.Length - 2; j++)
                {
                    if (p == cells[j + 1])
                    {
                        p = cells[j];
                        cells[j] = 1;
                    }
                    else
                    {
                        p = cells[j];
                        cells[j] = 0;
                    }
                }

                cells[0] = 0;
                cells[cells.Length - 1] = 0;

                var str = GetString(cells);

                
            }

            return cells;
        }

        public string GetString(int[] cells)
        {
            var sb = new StringBuilder();

            foreach(var n in cells)
            {
                sb.Append(n);
            }

            return sb.ToString();
        }
    }
}
