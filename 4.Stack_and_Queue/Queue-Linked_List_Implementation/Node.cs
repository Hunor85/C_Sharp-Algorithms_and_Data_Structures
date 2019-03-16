using System;
namespace QueueLinked_List_Implementation
{
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
