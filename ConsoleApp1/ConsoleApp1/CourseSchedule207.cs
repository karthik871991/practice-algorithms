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

            var graph = new Dictionary<int, List<int>>();

            for (int i = 0; i < prerequisites.Length; i++)
            {
                if (graph.ContainsKey(prerequisites[i][0]))
                {
                    graph[prerequisites[i][0]].Add(prerequisites[i][1]);
                }
                else
                {
                    graph.Add(prerequisites[i][0], new List<int> { prerequisites[i][1] });
                }
            }

            var visitingSet = new HashSet<int>();
            var visitedSet = new HashSet<int>();

            foreach (var kvp in graph)
            {
                if (!visitedSet.Contains(kvp.Key))
                {
                    var found = IsLoopFound(visitingSet, visitedSet, graph, kvp.Key);

                    if (found)
                        return false;
                }
            }

            return true;
        }

        private bool IsLoopFound(HashSet<int> visitingSet, HashSet<int> visitedSet, Dictionary<int, List<int>> graph, int course)
        {
            if (visitingSet.Contains(course))
            {
                return true;
            }

            visitingSet.Add(course);

            var list = graph.GetValueOrDefault(course);
            if (list != null)
            {
                foreach (var item in list)
                {
                    if (!visitedSet.Contains(item))
                    {
                        var found = IsLoopFound(visitingSet, visitedSet, graph, item);

                        if (found)
                            return true;
                    }

                    visitedSet.Add(item);
                }
            }

            return false;
        }
    }
}