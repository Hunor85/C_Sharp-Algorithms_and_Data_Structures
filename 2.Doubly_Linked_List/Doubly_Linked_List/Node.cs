using System;
namespace Doubly_Linked_List
{
    public class Node
    {
        public Node prev;
        public int info;
        public Node next;

        public Node(int i)
        {
            info = i;
            prev = null;
            next = null;
        }
    }
}
