namespace AlgoPractice.Tree
{
    public class GenericBinaryTreeNode<T>
    {
        public T Value { get; set; }
        public GenericBinaryTreeNode<T> Left { get; set; }
        public GenericBinaryTreeNode<T> Right { get; set; }
    }
}