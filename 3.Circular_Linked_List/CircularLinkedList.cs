using System;
namespace Circular_Linked_List
{
    public class CircularLinkedList
    {
        private Node last;

        public CircularLinkedList()
        {
            last = null;
        }

        public void DisplayList()
        {
            if (last == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Node p = last.link;
            do
            {
                Console.Write(p.info + " ");
                p = p.link;
            } while (p != last.link);

            Console.WriteLine();
        }

        public void InsertInBeginning(int data){
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
        }

        public void InsertInEmptyList(int data){
            Node temp = new Node(data);
            last = temp;
            last.link = last;
        }

        public void InsertAtEnd(int data){
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
            last = temp;
        }

        public void CreateList(){
            int i, n, data;

            Console.WriteLine("Enter the number of nodes: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;
            Console.Write("Enter the element to be inserted: ");
            data = Convert.ToInt32(Console.ReadLine());
            InsertInEmptyList(data);

            for (i = 2; i <= n; i++){
                Console.Write("Enter the element to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        public void InsertAfter(int data, int x){
            Node p = last.link;
            do {
                if (p.info == x)
                    break;
                p = p.link;
            } while(p != last.link);

            if (p == last.link && p.info != x)
                Console.WriteLine(x + " not present in the list.");
            else{
                Node temp = new Node(data);
                temp.link = p.link;
                if (p == last)
                    last = temp;
            }
        }
    }
}
