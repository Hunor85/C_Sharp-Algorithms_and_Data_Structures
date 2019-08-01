using System;
namespace Binary_tree
{
    public class Node
    {
        public Node lChild;
        public Node rChild;
        public char info;
        public Node(char n)
        {
            info = n;
            lChild = null;
            rChild = null;
        }
    }
}
