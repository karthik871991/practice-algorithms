using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractice.Tree
{
    public class SearchBSTForTarget
    {
        public bool FindTarget(TreeNode root, int k)
        {
            if (root == null)
                return false;

            //var found = Find(root, k - root.val);

            //if (found)
            //    return true;

            return FindTarget(root.left, k - root.val) || FindTarget(root.right, k - root.val);
        }

        private bool Find(TreeNode root, int k)
        {
            if (root == null)
                return false;

            if (root.val == k)
                return true;
            else if (root.val >= k)
            {
                return Find(root.left, k);
            }
            else
            {
                return Find(root.right, k);
            }
        }
    }
}
