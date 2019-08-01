using System;

namespace Binary_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            bt.CreateTree();
            bt.Display();
            Console.WriteLine();

            Console.WriteLine("PreOrder : ");
            bt.PreOrder();
            Console.WriteLine("");

            Console.WriteLine("InOrder : ");
            bt.InOrder();
            Console.WriteLine("");

            Console.WriteLine("PostOrder : ");
            bt.PostOrder();
            Console.WriteLine("");

            Console.WriteLine("LevelOrder : ");
            bt.LevelOrder();
            Console.WriteLine("");

            Console.WriteLine("The Height of tree is " + bt.Height());
        }
    }
}
