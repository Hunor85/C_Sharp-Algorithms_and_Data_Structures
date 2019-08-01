using System;
namespace Deque
{
    public class DequeArray
    {
        private int[] queueArray;
        private int front;
        private int rear;

        public DequeArray()
        {
            queueArray = new int[10];
            front = -1;
            rear = -1;
        }

        public DequeArray(int maxSize)
        {
            queueArray = new int[maxSize];
            front = -1;
            rear = -1;
        }

        public void InsertFront(int x)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue overflow.");
                return;
            }

            if (front == -1)
            {
                front = 0;
                rear = 0;
            }
            else if (front == 0)
                front = queueArray.Length - 1;
            else
                front = front - 1;
            queueArray[front] = x;
        }

        public void InsertRear(int x)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue overflow.");
                return;
            }

            if (front == -1)
                front = 0;

            if (rear == queueArray.Length - 1)
                rear = 0;
            else
                rear = rear + 1;
            queueArray[rear] = x;
        }

        public int DeleteFront()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("Queue underflow.");

            int x = queueArray[front];

            /* only one element*/
            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else if (front == queueArray.Length - 1)
                front = 0;
            else
                front = front + 1;
            return x;
        }

        public int DeleteRear()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("Queue underflow.");

            int x = queueArray[rear];

            /* only one element*/
            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else if (rear == 0)
                rear = queueArray.Length-1;
            else
                rear = rear - 1;
            return x;
        }

        public bool IsEmpty()
        {
            return (front == -1);
        }

        public bool IsFull()
        {
            return ((front == 0 && rear == queueArray.Length - 1)
            || (front == rear + 1));
        }

        public void Display()
        {
            int i;

            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty: ");
                return;
            }

            Console.WriteLine("Queue is: ");

            i = front;
            if (front <= rear)
            {
                while (i <= rear)
                    Console.WriteLine(queueArray[i++] + " ");
            }
            else
            {
                while (i <= queueArray.Length-1)
                    Console.WriteLine(queueArray[i++] + " ");
                i = 0;
                while (i <= rear)
                    Console.WriteLine(queueArray[i++] + " ");
            }
            Console.WriteLine();
        }
    }
}
