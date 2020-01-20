using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class AlgoPractice
    {
        public class Sample
        {
            public int A { get; set; }
            public int B { get; set; }
        }
        static void Main(string[] args)
        {
            var nums = new int[] { 6, 7, 0, 1, 2, 3, 4 };
            var people = new int[6][] 
            { new int[]{7, 0 }, 
            new int[]{4, 4 }, 
            new int[]{7, 1}, 
            new int[]{5, 0}, 
            new int[]{6, 1},
            new int[]{5, 2}};

            var result = ReconstructQueue(people);

            //Search(nums, 0);

            Console.ReadKey();
        }
        public static int[][] ReconstructQueue(int[][] people)
        {
            var list = new LinkedList<string>();
            var map = Enumerable.Range(0, people.Length).ToList();

            var sorted = people.OrderBy(p => p[0]).ThenByDescending(p => p[1]);

            foreach (var person in sorted)
            {
                people[map[person[1]]] = new[] { person[0], person[1] };
                map.RemoveAt(person[1]);
            }

            return people;
        }
        public static int Search(int[] nums, int target)
        {
            int lo = 0, hi = nums.Length - 1;
            // find the index of the smallest value using binary search.
            // Loop will terminate since mid < hi, and lo or hi will shrink by at least 1.
            // Proof by contradiction that mid < hi: if mid==hi, then lo==hi and loop would have been terminated.
            while (lo < hi)
            {
                int mid = (lo + hi) / 2;
                if (nums[mid] > nums[hi]) lo = mid + 1;
                else hi = mid;
            }

            Console.WriteLine(nums[lo]);
            return 0;
        }

        

        public bool ValidTree(int n, int[][] edges)
        {
            if (edges.Length == 0) return true;
            var set = new HashSet<int>();
            set.Add(edges[0][0]);
            set.Add(edges[0][1]);
            for (int i = 1; i < edges.Length; i++)
            {
                foreach (var item in set)
                {
                    Console.Write(item);
                }
                Console.WriteLine("-------------1");
                var a = edges[i][0];
                var b = edges[i][1];

                if (set.Contains(a) && set.Contains(b)) return false;

                if (set.Contains(a) || set.Contains(b))
                {
                    set.Add(a);
                    set.Add(b);
                }

                if (!set.Contains(a) && !set.Contains(b)) return false;

                foreach (var item in set)
                {
                    Console.Write(item);
                }
                Console.WriteLine("-----------------2");
            }

            return true;
        }

        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var set = Visit(rooms);

            return set.Count == rooms.Count;
        }

        private HashSet<int> Visit(IList<IList<int>> rooms)
        {
            var q = new Queue<int>();
            q.Enqueue(0);

            var set = new HashSet<int>();
            set.Add(0);

            while (q.Count != 0)
            {
                var index = q.Dequeue();
                for (int i = 0; i < rooms[index].Count; i++)
                {
                    if (!set.Contains(index))
                    {
                        Console.WriteLine(rooms[index][0]);
                        set.Add(index);
                        q.Enqueue(rooms[index][i]);
                    }
                }

                Console.WriteLine(index);

            }

            return set;
        }


        public static int GetDayDate(int year)
        {
            var day = dayofweek(1, 10, year);

            var num = day - 2;

            int dayToCalculate = 1;

            if (num < 0)
            {
                dayToCalculate += 7 + Math.Abs(day - 2);
            }
            else if (num > 0)
            {
                dayToCalculate += 7 + 7 - day + 2;
            }
            else
            {
                dayToCalculate += 7;
            }


            return dayToCalculate;
        }

        public static int dayofweek(int d, int m, int y)
        {
            int[] t = { 0, 3, 2, 5, 0, 3, 5,
                            1, 4, 6, 2, 4 };
            y -= (m < 3) ? 1 : 0;

            return (y + y / 4 - y / 100 + y / 400
                             + t[m - 1] + d) % 7;
        }

        public static List<string> GetStrings(string inputStr, int number)
        {
            var answer = new HashSet<string>();

            for (int i = 0; i <= inputStr.Length - number; i++)
            {
                var subString = inputStr.Substring(i, number);

                var l = subString.Distinct().Count();
                if (subString.Length == subString.Distinct().Count())
                {
                    answer.Add(subString);
                }

            }

            return answer.ToList();
        }

        public static List<String> retrieveMostFrequentlyUsedWords(String literatureText,
                                                   List<String> wordsToExclude)
        {
            if (string.IsNullOrWhiteSpace(literatureText))
            {
                return new List<string>();
            }
            var hashset = new HashSet<string>();
            if (!(wordsToExclude == null || wordsToExclude.Count == 0))
            {
                hashset = new HashSet<string>(wordsToExclude);
            }

            var wordArr = literatureText
                            .Replace("!", " ")
                            .Replace("?", " ")
                            .Replace("'", " ")
                            .Replace(",", " ")
                            .Replace(".", " ")
                            .Replace(";", " ")
                            .ToLower()
                            .Split(' ');

            var countWords = new Dictionary<string, int>();

            foreach (var actualWord in wordArr)
            {
                var word = actualWord.ToLower();
                if (!string.IsNullOrWhiteSpace(word) && !hashset.Contains(word))
                {
                    if (countWords.ContainsKey(word))
                    {
                        countWords[word]++;
                    }
                    else
                    {
                        countWords.Add(word, 1);
                    }
                }
            }

            int max = 0;
            string result = string.Empty;

            var sorted = countWords.OrderByDescending(x => x.Value).GroupBy(y => y.Value);

            var answer = new List<string>();

            var words = sorted.FirstOrDefault();

            if (words == null || !words.Any())
            {
                return new List<string>();
            }

            foreach (var item in sorted.First())
            {
                answer.Add(item.Key);
            }

            return answer;
        }
    }
}