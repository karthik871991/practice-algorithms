namespace AlgoPractice
{
    public class CopyRandomListPointer
    {
        public Node CopyRandomList(Node head)
        {
            var currentNode = head;

            while (currentNode != null)
            {
                var nextNode = currentNode.next;

                var newNode = new Node { val = currentNode.val };
                currentNode.next = newNode;
                newNode.next = nextNode;

                currentNode = nextNode;
            }

            currentNode = head;

            while (currentNode != null)
            {
                if(currentNode.random != null)
                {
                    currentNode.next.random = currentNode.random.next;
                }

                currentNode = currentNode.next.next;
            }

            var resultNode = new Node();

            currentNode = head;
            var copyIter = resultNode;

            while(currentNode != null)
            {
                var originalNextNode = currentNode.next.next;

                copyIter.next = currentNode.next;
                copyIter = currentNode;

                currentNode.next = originalNextNode;
                currentNode = originalNextNode;
            }

            return resultNode.next;
        }
    }

    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node() { }
        public Node(int _val, Node _next, Node _random)
        {
            val = _val;
            next = _next;
            random = _random;
        }
    }
}