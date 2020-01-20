using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice.MS
{
    public class DayofWeek
    {
        public string Day(string day, int K)
        {
            var days = new Dictionary<string, int> { { "Sun", 0 }, { "Mon", 1 }, { "Tue", 2 }, { "Wed", 3 }, { "Thu", 4 }, { "Fri", 5 }, { "Sat", 6 } };

            return days.Single(x => x.Value == (days[day] + K) % 7).Key;
        }
    }
}
