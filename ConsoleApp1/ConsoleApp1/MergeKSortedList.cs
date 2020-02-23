using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractice
{
    public class MergeKSortedList
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            var pq = new PriorityQueue();

            for (int i = 0; i < lists.Length; i++)
            {
                pq.Enqueue(lists[i]);
            }

            var result = new ListNode(0);
            var cur = result;
            while (pq.Any())
            {
                var curNode = pq.Dequeue();

                cur.next = curNode;
                cur = cur.next;

                if (curNode.next != null)
                    pq.Enqueue(curNode.next);
            }

            return result.next;
        }

        public class PriorityQueue
        {
            private SortedDictionary<int, Queue<ListNode>> map = new SortedDictionary<int, Queue<ListNode>>();

            public void Enqueue(ListNode node)
            {
                if (node == null)
                    return;

                if (!map.ContainsKey(node.val))
                {
                    map.Add(node.val, new Queue<ListNode>());
                }

                map[node.val].Enqueue(node);
            }

            public ListNode Dequeue()
            {
                if (map.Any())
                {
                    var first = map.FirstOrDefault();

                    var toReturn = first.Value.Dequeue();

                    if (!first.Value.Any())
                        map.Remove(first.Key);

                    return toReturn;
                }

                throw new InvalidOperationException();
            }

            public bool Any()
            {
                return map.Count > 0;
            }
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
