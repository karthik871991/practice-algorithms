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
