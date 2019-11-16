using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice
{
    public class CourseSchedule207
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            if (prerequisites.Length == 0)
                return false;

            var graph = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < prerequisites.Length; i++)
            {
                if (graph.ContainsKey(prerequisites[i][0]))
                {
                    graph[prerequisites[i][0]].Add(prerequisites[i][1]);
                }
                else
                {
                    graph.Add(prerequisites[i][0], new HashSet<int> { prerequisites[i][1] });
                }
            }

            var q = new Queue<int>();

            q.Enqueue(graph.First().Key);
            var v = new HashSet<int>();

            while (q.Count != 0)
            {
                var node = q.Dequeue();

                if (v.Contains(node))
                    return false;
                else
                    v.Add(node);

                if (graph.ContainsKey(node))
                    foreach (var n in graph[node])
                    {
                        q.Enqueue(n);
                    }
            }

            return true;
        }
    }
}