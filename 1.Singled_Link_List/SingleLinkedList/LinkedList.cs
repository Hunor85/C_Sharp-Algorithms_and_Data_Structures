using System;
namespace SingleLinkedList
{
    public class LinkedList
    {
        private Node start;

        public LinkedList()
        {
            start = null;
        }

        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.Write("List is : ");
            p = start;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }


        public void CountNodes()
        {
            int n = 0;
            Node p = start;
            while (p != null)
            {
                n++;
                p = p.link;
            }
            Console.WriteLine("Number of nodes in the list = " + n);
        }

        public bool Search(int x)
        {
            int position = 1;
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                position++;
                p = p.link;
            }
            if (p == null)
            {
                Console.WriteLine(x + " not found in list");
                return false;
            }
            else
            {
                Console.WriteLine(x + " is a position " + position);
                return true;
            }
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;
        }

        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);

            if (start == null)
            {
                start = temp;
                return;
            }

            p = start;
            while (p.link != null)
                p = p.link;

            p.link = temp;
        }

        public void InsertAfter(int data, int x)
        {
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                p = p.link;
            }

            if (p == null)
                Console.WriteLine(x + " not present  the list");
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertBefore(int data, int x)
        {
            Node temp;

            // if list is empty
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // if x is the first node the new node will be inserted before the first node
            if (x == start.info)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            // finding reference to predecessor of node containing x
            Node p = start;
            while (p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }

            if (p.link == null)
                Console.WriteLine(x + " not present in the list");
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertAtPosition(int data, int k)
        {
            Node temp;
            int i;

            if (k == 1)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;
            for (i = 1; i < k - 1 && p != null; i++)
                p = p.link;

            if (p == null)
                Console.WriteLine("You can insert only up to " + i + " th position");
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void DeleteFirstNode()
        {
            if (start == null)
                return;
            start = start.link;
        }

        public void DeleteLastNode()
        {
            if (start == null)
                return;

            if (start.link == null)
            {
                start = null;
                return;
            }

            Node p = start;
            while (p.link.link != null)
                p = p.link;
            p.link = null;
        }

        public void DeleteNode(int x)
        {

            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // Deleting the first node
            if (start.info == x)
            {
                start = start.link;
                return;
            }

            // Deleting between nodes or at the end 
            Node p = start;
            while (p.link != null)
            {
                if (p.link.info != x)
                    break;
                p = p.link;
            }

            if (p.link == null)
                Console.WriteLine("Element " + x + " not in the list");
            else
                p.link = p.link.link;
        }

        public void ReverseList()
        {
            Node prev, p, next;
            prev = null;
            p = start;
            while (p != null)
            {
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }
            start = prev;
        }


        public void BubbleSortExData()
        {
            Node p, q, end;

            for (end = null; end != start.link; end = p)
            {
                for (p = start; p.link != end; p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        int temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }
                }
            }
        }


        public void BubbleSortExLinks()
        {
            Node end, r, p, q, temp;

            for (end = null; end != start.link; end = p)
            {
                for (r = p = start; p.link != end; r = p, p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        p.link = q.link;
                        q.link = p;
                        if (p != start)
                            r.link = q;
                        else
                            start = q;
                        temp = p;
                        p = q;
                        q = temp;
                    }
                }

            }
        }

        public LinkedList Merge1(LinkedList list)
        {
            LinkedList mergeList = new LinkedList();
            mergeList.start = Merge1(start, list.start);
            return mergeList;
        }

        private Node Merge1(Node p1, Node p2){
            Node startM;

            if(p1.info <= p2.info){
                startM = new Node(p1.info);
                p1 = p1.link;
            } else {
                startM = new Node(p2.info);
                p2 = p2.link;
            }

            Node pM = startM;

            while(p1 != null && p2 != null){
                if(p1.info <= p2.info){
                    pM.link = new Node(p1.info);
                    p1 = p1.link;
                } else {
                    pM.link = new Node(p1.info);
                    p2 = p2.link;
                }
                pM = pM.link;
            }

            /*If second list is finished*/
            while(p1 != null){
                pM.link= new Node(p1.info);
                p1 = p1.link;
                pM = pM.link;
            }

            /*If first list is finished*/
            while(p2 != null){
                pM.link = new Node(p2.info);
                p2 = p2.link;
                pM = pM.link;
            }
            return startM;
        }

        public LinkedList Merge2(LinkedList list)
        {
            LinkedList mergeList = new LinkedList();
            mergeList.start = Merge1(start, list.start);
            return mergeList;
        }

        private Node Merge2(Node p1, Node p2){
            Node startM;

            if(p1.info <= p2.info){
                startM = p1;
                p1 = p1.link;
            } else {
                startM = p2;
                p2 = p2.link;
            }

            Node pM = startM;

            while(p1 != null && p2 != null){
                if(p1.info <= p2.info){
                    pM.link = p1;
                    pM = pM.link;
                    p1 = p1.link;
                } else {
                    pM.link = p2;
                    pM = pM.link;
                    p2 = p2.link;
                }
            }

            if (p1 == null)
                pM.link = p2;
            else
                pM.link = p1;
            return startM;
        }

        public void MergeSort(){ /* Public method for MergeSort */
            start = MergeSortRec(start); /* Calling the private recursive method */
        }

        private Node MergeSortRec(Node listStart){ /* ListStart is reference to first Node of the list that needs to be sorted */

            if (listStart == null || listStart.link == null) /* If list is empty or has only one element */
                return listStart;

            /* If list has more than one element */
            Node start1 = listStart; /* start1 refers to 1st Node of the 1st list. start1 is the original list that needs to be divided. */
            Node start2 = DivideList(listStart); /* start2 refers to 1st Node of the 2nd list */
            start1 = MergeSortRec(start1); /* A list that is recursively sorted */
            start2 = MergeSortRec(start2); /* A list that is recursively sorted */
            Node startM = Merge2(start1, start2); /* Merging start1 and start2 after being sorted. 
                                                    startM is the reference to the 1st Node of the merged list */
            return startM; /* Exiting from the method */
        }

        private Node DivideList(Node p){ /* p refers to the 1st Node of the original list that needs to be divided */
            
            Node q = p.link.link; /* q refers to the 3rd Node of the original list that needs to be divided */

            while(q != null && q.link != null){ /* q becomes null if the list has even number of Nodes
                                                    q.link becomes null if the list has odd number of Nodes */
                
                p = p.link; /* moving p one Node at a time */
                q = q.link.link; /* moving 1 two Nodes at a time */
            }
            Node start2 = p.link; /* after while-loop terminates we assign p.link to start2 */
            p.link = null; /* assign null to p.link */
            return start2; /* returning to 1st Node of the second element */
        }

        public bool HasCycle(){ /* HasCycle() returns true if the list has a cycle */
            if (FindCycle() == null) /* calling FindCycle() */
                return false;
            else
                return true;
        }

        private Node FindCycle(){ /* returns null if list has no cycle; 
                                    otherwise return Node where slowR and fastR meet */
            if (start == null || start.link == null)
                return null;

            Node slowR = start, fastR = start; /* slowR and fastR references refer to the first node of the list => start */

            while(fastR != null && fastR.link != null){
                
                slowR = slowR.link; /* move slowR one Node at a time */
                fastR = fastR.link.link; /* move fastR two Nodes at a time */
                if (slowR == fastR) /* return reference to the Node where slowR and fastR meet */
                    return slowR;
            }
            return null;
        }

        public void RemoveCycle(){
            
            Node c = FindCycle(); /* returns reference to the Node where slowR and fastR meet */
            if (c == null)
                return;
            Console.WriteLine("Node at which the cycle is detected is " + c.info);

            Node p = c, q = c; /* making two references to the Node where slowR and fastR meet */

            int lenCycle = 0; /* finding the length of the cycle */
            do
            {
                lenCycle++;
                q = q.link; /* moving q one Node at a time */
            } while (p != q);
            Console.WriteLine("Length of cycle is : " + lenCycle);

            int lenRemList = 0; /* finding the length of the remaining list */
            p = start; /* p refers to the first node of the list */
            while( p != q){
                lenRemList++;
                p = p.link; /* moving p one node at a time */
                q = q.link; /* moving q one node at a time */
            }

            Console.WriteLine("Number of nodes not included in the cycle are : " + lenRemList);

            int lengthList = lenCycle + lenRemList; /* finding the length of the whole list */
            Console.WriteLine("Length of the list is : " + lengthList);

            /* removing the cycle from the list */
            p = start; /* making reference to the first node of the list */
            for (int i = 1; i <= lengthList - 1; i++) /* moving the reference lengthList-1 times */
                p = p.link;
            p.link = null; /* putting null in the place of link */

        }

        public void InsertCycle(int x){
            if (start == null)
                return;

            Node p = start, px = null, prev = null;

            while(p != null){
                if (p.info == x)
                    px = p;
                prev = p;
                p = p.link;
            }
            if (px != null)
                prev.link = px;
            else
                Console.WriteLine(x + " not present in list");
        }

        public void CreateList(){
            int i, n, data;

            Console.WriteLine("Enter the number of nodes : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter the element to be inserted : ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }
    }
}

// video 18.
// video 19.