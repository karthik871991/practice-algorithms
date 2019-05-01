namespace AlgoPractice.Tree
{
    public class Tree
    {
        private TreeNode _root = null;

        public Tree()
        {
        }

        public TreeNode BuildTree(int value)
        {
            _root = AddNodeToTree(_root, value);
            return _root;
        }

        private TreeNode AddNodeToTree(TreeNode current, int value)
        {
            if(current == null)
            {
                return new TreeNode { Value = value };
            }
            //else if()
            //{
            //    current.Left = AddNodeToTree(current.Left, value);
            //    current.Right = AddNodeToTree(current.Right, value);
            //}

            return current;
        }

        public TreeNode GetRoot()
        {
            return _root;
        }
    }
}