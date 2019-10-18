using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice
{
    public class Word_Ladder
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            var set = new HashSet<string>(wordList);
            var visited = new HashSet<string>();

            visited.Add(beginWord);

            var q = new Queue<string>();
            q.Enqueue(beginWord);

            int counter = 1;

            while (q.Count != 0)
            {
                int size = q.Count;

                for (int z = 0; z < size; z++) 
                {
                    var word = q.Dequeue();
                    for (int i = 0; i < word.Length; i++)
                    {
                        for (int j = 0; j < 26; j++)
                        {
                            var p1 = word.Substring(0, i);
                            var p2 = (char)(j + 97);
                            var p3 = word.Substring(i + 1, word.Length - i - 1);
                            var newWord = p1 + p2 + p3;

                            if (newWord == endWord && set.Contains(endWord))
                                return counter + 1;

                            if (set.Contains(newWord) && !visited.Contains(newWord))
                            {
                                q.Enqueue(newWord);
                                visited.Add(newWord);
                            }
                        }
                    }
                }

                counter++;
            }

            return 0;
        }
    }
}
