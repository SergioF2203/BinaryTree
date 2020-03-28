using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumDepthOfBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode tn1 = new TreeNode(1);
            TreeNode tn2 = new TreeNode(2);
            TreeNode tn7 = new TreeNode(7);
            TreeNode tn4 = new TreeNode(4);
            tn4.right = tn1;
            TreeNode tn13 = new TreeNode(13);
            TreeNode tn11 = new TreeNode(11);
            tn11.left = tn7;
            tn11.right = tn2;
            TreeNode tn8 = new TreeNode(8);
            tn8.right = tn4;
            tn8.left = tn13;
            TreeNode tn4_2 = new TreeNode(4);
            tn4_2.left = tn11;
            TreeNode tn5 = new TreeNode(5);
            tn5.left = tn4_2;
            tn5.right = tn8;

            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);
            //root.left.left = new TreeNode(3);
            //root.left.right = new TreeNode(3);
            root.right.left = new TreeNode(3);
            root.right.right = new TreeNode(3);
            //root.left.left.left = new TreeNode(4);
            //root.left.left.right = new TreeNode(4);
            //root.left.right.left = new TreeNode(4);
            //root.left.right.right = new TreeNode(4);
            //root.right.left.left = new TreeNode(4);
            //root.right.left.right = new TreeNode(4);
            //root.right.right.left = new TreeNode(4);
            //root.right.right.right = new TreeNode(4);
            //root.left.left.left.left = new TreeNode(5);
            //root.left.left.left.right = new TreeNode(5);

            Solution.MinDepth(root);

            //Solution.IsBalanced(root);

            //Solution.MaxDepth(temp);

            //Solution.HasPathSum(tn4, 4);
        }
    }
}
