using System;
namespace Binary_Search_Tree
{
public class BinarySearchTree
{
    private Node root;

    public BinarySearchTree()
    {
        root = null;
    }

    public bool IsEmpty()
    {
        return (root == null);
    }

    public void Insert(int x)
    {
        root = Insert(root, x);
    }

    // recursive method
    private Node Insert(Node p, int x)
    {
        if (p == null)
            p = new Node(x);
        else if (x < p.info)
        {
            p.lChild = Insert(p.lChild, x);
        }
        else if (x > p.info)
        {
            p.rChild = Insert(p.rChild, x);
        }
        else
        {
            Console.WriteLine(x + " already present in tree");
        }
        return p;
    }

    // iterative method
    public void Insert1(int x)
    {
        Node p = root;
        Node par = null;
        while (p != null)
        {
            par = p;
            if (x < p.info)
                p = p.lChild;
            else if (x > p.info)
                p = p.rChild;
            else
            {
                Console.WriteLine(x + " already present in tree");
                return;
            }
        }
        Node temp = new Node(x);
        if (par == null)
            root = temp;
        else if (x < par.info)
            par.lChild = temp;
        else
            par.rChild = temp;
    }

    public bool Search(int x)
    {
        return (Search(root, x) != null);
    }

    // recursive method
    private Node Search(Node p, int x)
    {
        if (p == null)
            return null;/*key not found*/

        if (x < p.info)
            return Search(p.lChild, x);/*search in left subtree*/
        if (x > p.info)
            return Search(p.rChild, x);/*search in right subtree*/

        return p;/*Key found!*/
    }

    // iterative method
    public bool Search1(int x)
    {
        Node p = root;
        while (p != null)
        {
            if (x < p.info)
                p = p.lChild;
            else if (x > p.info)
                p = p.rChild;
            else
                return true;
        }
        return false;
    }

    public void Delete(int x)
    {
        root = Delete(root, x);
    }

    private Node Delete(Node p, int x)
    {
        Node ch, s;
        if (p == null)
        {
            Console.WriteLine(x + "not found.");
            return p;
        }
        if (x < p.info)
            p.lChild = Delete(p.lChild, x);
        else if (x > p.info)
            p.rChild = Delete(p.rChild, x);
        else
        {
            /*key to be deleted was founded */
            if (p.lChild != null && p.rChild != null) /*2 children*/
            {
                s = p.rChild;
                while (s.lChild != null)
                    s = s.lChild;
                p.info = s.info;
                p.rChild = Delete(p.rChild, s.info);
            }
            else /*1 child or no child*/
            {
                if (p.lChild != null)
                {
                    ch = p.lChild;
                }
                else
                {
                    ch = p.rChild;
                }
                p = ch;
            }
        }
        return p;
    }

    public void Delete1(int x)
    {
        Node p = root;
        Node par = null;
        while (p != null)
        {
            if (x == p.info)
                break;
            par = p;
            if (x < p.info)
                p = p.lChild;
            else
            {
                p = p.rChild;
            }
        }
        if (p == null)
        {
            Console.WriteLine(x + " not found");
            return;
        }

        /*
            * 
            * Case C: 2 children
            Find inorder successor and its parent  
            */

        Node s, ps;
        if (p.lChild != null && p.rChild != null)
        {

            ps = p;
            s = p.rChild;
            while (s.lChild != null)
            {
                ps = s;
                s = s.lChild;
            }
            p.info = s.info;
            p = s;
            par = ps;
        }

        /*Case B and Case A: 1 or no child*/
        Node ch;
        if (p.lChild != null) /*Node to be deleted has left child*/
            ch = p.lChild;
        else   /*Node to be deleted has right child or no child*/
            ch = p.rChild;

        if (par == null)/*Node to be deleted is the root node*/
            root = ch;
        else if (p == par.lChild)/*Node is left child of its parent*/
            par.lChild = ch;
        else
            par.rChild = ch;/*Node is right child of its parent*/
    }

    public int Min()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Tree is empty");
        }
        return Min(root).info;
    }

    private Node Min(Node p)
    {
        if (p.lChild == null)
            return p;
        return Min(p.lChild);
    }

    public int Max()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Tree is empty");
        }
        return Max(root).info;
    }

    private Node Max(Node p)
    {
        if (p.rChild == null)
            return p;
        return Max(p.rChild);
    }

    public int Min1()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Tree is empty");
        }
        Node p = root;
        while (p.lChild != null)
            p = p.lChild;

        return p.info;
    }

    public int Max1()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Tree is empty");
        }
        Node p = root;
        while (p.rChild != null)
            p = p.rChild;

        return p.info;
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
            Console.WriteLine("    ");
        Console.WriteLine(p.info);
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

        Console.Write(p.info + " ");
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

    public int Height()
    {
        return Height(root);
    }

    public int Height(Node p)
    {
        int hL, hR;
        if (p == null)
            return 0;

        hL = Height(p.lChild);
        hR = Height(p.rChild);
        if (hL > hR)
            return 1 + hL;
        else
            return 1 + hR;
    }
}
}
