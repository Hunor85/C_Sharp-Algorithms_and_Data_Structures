using System;
namespace Linked_List_Implementation
{
    // Class repersenting a single node 
    public class Node
    {
        public int info;
        public Node link;

        public Node(int i)
        {
            info = i;
            link = null;
        }
    }   
}
