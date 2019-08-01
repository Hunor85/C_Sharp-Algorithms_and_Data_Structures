using System;
namespace Binary_tree_sort
{
    public class TreeNode
    {
        public TreeNode lchild;
        public TreeNode rchild;
        public int info;

        public TreeNode(int n)
        {
            info = n;
            lchild = null;
            rchild = null;
        }
    }
}
