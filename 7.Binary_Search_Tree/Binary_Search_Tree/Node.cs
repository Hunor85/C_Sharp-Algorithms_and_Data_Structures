using System;
namespace Binary_Search_Tree
{
    public class Node
    {
        public Node lChild;
        public Node rChild;
        public int info;
        public Node(int i)
        {
            info = i;
            lChild = null;
            rChild = null;
        }
    }
}
