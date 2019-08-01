using System;
using System.Collections.Generic;
using System.Linq;

namespace Binary_tree
{
    public class BinaryTree
    {
        private Node root;

        public BinaryTree()
        {
            root = null;
        }

        public void Display()
        {
            Display(root, 0);
            Console.WriteLine();
        }

        private void Display(Node p, int level)
        {
            int i;
            if (p == null)
            {
                return;
            }
            Display(p.rChild, level + 1);
            Console.WriteLine();
            for (i = 0; i < level; i++)
                Console.WriteLine("   ");

            Console.Write(p.info);

            Display(p.lChild, level + 1);
        }

        public void PreOrder()
        {
            PreOrder(root);
            Console.WriteLine();
        }

        private void PreOrder(Node p)
        {
            if (p == null)
                return;
            Console.WriteLine(p.info + " ");
            PreOrder(p.lChild);
            PreOrder(p.rChild);
        }

        public void InOrder()
        {
            InOrder(root);
            Console.WriteLine();
        }

        private void InOrder(Node p)
        {
            if (p == null)
                return;
            InOrder(p.lChild);
            Console.WriteLine(p.info + " ");
            InOrder(p.rChild);
        }

        public void PostOrder()
        {
            PostOrder(root);
            Console.WriteLine();
        }

        private void PostOrder(Node p)
        {
            if (p == null)
                return;
            PostOrder(p.lChild);
            PostOrder(p.rChild);
            Console.WriteLine(p.info + " ");
        }

        public void LevelOrder()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }

            Queue<Node> qu = new Queue<Node>();
            qu.Enqueue(root);

            Node p;
            while (qu.Count() != 0)
            {
                p = qu.Dequeue();
                Console.Write(p.info + " ");
                if (p.lChild != null)
                {
                    qu.Enqueue(p.lChild);
                }
                if (p.rChild != null)
                {
                    qu.Enqueue(p.rChild);
                }
            }
            Console.WriteLine();
        }

        public int Height()
        {
            return Height(root);
        }

        public int Height(Node p)
        {
            if (p == null)
                return 0;

            int hL = Height(p.lChild);
            int rL = Height(p.rChild);

            if (hL > rL)
            {
                return 1 + hL;
            }
            else
            {
                return 1 + rL;
            }
        }

        public void CreateTree()
        {
            root = new Node('P');
            root.lChild = new Node('Q');
            root.rChild = new Node('R');
            root.lChild.lChild = new Node('A');
            root.lChild.rChild = new Node('B');
            root.rChild.lChild = new Node('X');
        }
    }
}
