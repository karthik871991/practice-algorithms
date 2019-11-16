using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice
{
    public class ValidateBinarySearchTree
    {
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
    }

    //public class TreeNode
    //{
    //    public int val;
    //    public TreeNode left;
    //    public TreeNode right;
    //}
}
