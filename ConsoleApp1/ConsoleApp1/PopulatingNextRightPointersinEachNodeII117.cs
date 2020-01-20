using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractice
{
    public class SampleTreeNode
    {
        public int val;
        public SampleTreeNode left;
        public SampleTreeNode right;
        public SampleTreeNode next;

        public SampleTreeNode() { }

        public SampleTreeNode(int _val)
        {
            val = _val;
        }

        public SampleTreeNode(int _val, SampleTreeNode _left, SampleTreeNode _right, SampleTreeNode _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
    public class PopulatingNextRightPointersinEachNodeII117
    {
        public SampleTreeNode Connect(SampleTreeNode root)
        {
            if (root == null)
                return null;

            var head = root;
            head.next = null;

            var q = new Queue<SampleTreeNode>();
            q.Enqueue(root);

            while (q.Any())
            {
                var size = q.Count;

                for (int i = 0; i < size; i++)
                {
                    var curr = q.Dequeue();

                    if (i == size - 1)
                        curr.next = null;
                    else
                        curr.next = q.Peek();

                    if (curr.left != null)
                        q.Enqueue(curr.left);

                    if (curr.right != null)
                        q.Enqueue(curr.right);
                }
            }

            return head;
        }
    }
}