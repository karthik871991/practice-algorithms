using System;

namespace AlgoPractice.Tree
{
    public class BinarySearchTree
    {
        public TreeNode BuildTree(int[] arr)
        {
            var node = new TreeNode { val = arr[0] };

            for (int i = 1; i < arr.Length; i++)
            {
                AddNode(arr[i], node);
            }

            return node;
        }

        public TreeNode BuildTreeRecursive(int[] arr)
        {
            Array.Sort(arr);
            return BuildTreeRecursive(arr, 0, arr.Length - 1);
        }

        private TreeNode BuildTreeRecursive(int[] arr, int l, int h)
        {
            if (l > h)
                return null;

            var mid = ((h + l) / 2);
            var node = new TreeNode { val = arr[mid] };

            node.left = BuildTreeRecursive(arr, l, mid - 1);
            node.right = BuildTreeRecursive(arr, mid + 1, h);

            return node;
        }
        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
                return true;

            return IsValid(root, long.MinValue, long.MaxValue);
        }

        private bool IsValid(TreeNode root, long min, long max)
        {
            if (root == null)
                return true;

            if (root.val <= min || root.val >= max)
                return false;

            return IsValid(root.left, min, root.val) && IsValid(root.right, root.val, max);
        }

        private void AddNode(int num, TreeNode node)
        {
            var pre = node;
            while (node != null)
            {
                pre = node;

                if (node.val > num)
                    node = node.left;
                else
                    node = node.right;
            }

            if (pre.val > num)
            {
                pre.left = new TreeNode { val = num };
            }
            else
            {
                pre.right = new TreeNode { val = num };
            }
        }

        public int FindDistance(TreeNode node1, TreeNode node2, TreeNode root)
        {
            return 0;
        }
    }
}
