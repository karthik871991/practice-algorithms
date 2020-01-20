using System.Collections.Generic;

namespace AlgoPractice
{
    public class MostCommonWord819
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            var hashSet = new HashSet<string>(banned);


            var wordArr = paragraph
                            .Replace("!", " ")
                            .Replace("?", " ")
                            .Replace("'", " ")
                            .Replace(",", " ")
                            .Replace(".", " ")
                            .Replace(";", " ")
                            .ToLower()
                            .Split(' ');

            var countWords = new Dictionary<string, int>();

            foreach (var word in wordArr)
            {
                if (!string.IsNullOrWhiteSpace(word) && !hashSet.Contains(word))
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

            foreach (var word in countWords)
            {
                if (word.Value >= max)
                {
                    max = word.Value;
                    result = word.Key;
                }
            }

            return result;
        }
    }
}