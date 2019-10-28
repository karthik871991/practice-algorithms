namespace AlgoPractice.Tree
{
    public class BinarySearchTree
    {
        public TreeNode BuildTree(int[] arr)
        {
            var node = new TreeNode { Value = arr[0] };

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

                if (node.Value > num)
                    node = node.Left;
                else
                    node = node.Right;
            }

            if (pre.Value > num)
            {
                pre.Left = new TreeNode { Value = num };
            }
            else
            {
                pre.Right = new TreeNode { Value = num };
            }
        }

        public int FindDistance(TreeNode node1, TreeNode node2, TreeNode root)
        {
            return 0;
        }
    }
}
