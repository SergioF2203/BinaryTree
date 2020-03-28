using System;
using System.Collections.Generic;

namespace MaximumDepthOfBinaryTree
{
    public class Solution
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            var stack = new Stack<(TreeNode node, int depth)>();
            stack.Push((root, 1));
            var maxDepth = 1;

            while (stack.Count > 0)
            {
                var (node, depth) = stack.Pop();
                if (depth > maxDepth) maxDepth = depth;
                if (node.left != null) stack.Push((node.left, depth + 1));
                if (node.right != null) stack.Push((node.right, depth + 1));
            }
            return maxDepth;
        }

        public static bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;

            var nodeStack = new Stack<(TreeNode, int)>();
            nodeStack.Push((root, root.val));

            while (nodeStack.Count > 0)
            {

                var temp = nodeStack.Pop();
                TreeNode node = temp.Item1;
                var localSum = temp.Item2;

                if (node.left != null) nodeStack.Push((node.left, localSum + node.left.val));
                if (node.right != null) nodeStack.Push((node.right, localSum + node.right.val));

                if (node.left == null && node.right == null && localSum == sum) return true;

            }

            return false;
        }

        public static bool IsBalanced(TreeNode root)
        {
            if (root == null || (root.left == null && root.right == null)) return true;

            var nodeStack = new Stack<(TreeNode, int)>();
            nodeStack.Push((root, 1));

            var minimum_level = int.MaxValue;
            var maximum_level = 0;

            var left_height = 0;
            var right_height = 0;

            while (nodeStack.Count > 0)
            {
                var temp_item = nodeStack.Pop();
                var node = temp_item.Item1;
                var height = temp_item.Item2;

                //if (node.left != null) nodeStack.Push(node.left le)

                //if (node.left == null && node.right == null && nodeStack.Count != 0)
                //    minimum_level = level < minimum_level ? level : minimum_level;
                //if (node.left == null && node.right == null && nodeStack.Count == 0)
                //    maximum_level = level;

                //if (node.left != null) nodeStack.Push((node.left, level + 1));
                //if (node.right != null) nodeStack.Push((node.right, level + 1));
            }

            minimum_level = minimum_level == int.MaxValue ? 1 : minimum_level;
            return Math.Abs(maximum_level - minimum_level) > 1 ? false : true;
        }

        public static int MinDepth(TreeNode root)
        {
            if (root == null) return 0;

            var nodeStack = new Stack<(TreeNode, int)>();

            nodeStack.Push((root, 1));
            var min_depth = int.MaxValue;

            while (nodeStack.Count > 0)
            {
                var temp = nodeStack.Pop();
                var node = temp.Item1;
                var depth = temp.Item2;

                if (node.left == null && node.right == null)
                {
                    min_depth = depth < min_depth ? depth : min_depth;
                }

                if (node.left != null) nodeStack.Push((node.left, depth + 1));
                if (node.right != null) nodeStack.Push((node.right, depth + 1));
            }

            return min_depth;
        }

        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null) return false;
            if (root.left == null && root.right == null) return true;

            var left_nodeStack = new Stack<TreeNode>();
            var right_nodeStack = new Stack<TreeNode>();

            left_nodeStack.Push(root.left);
            right_nodeStack.Push(root.right);

            while(left_nodeStack.Count > 0)
            {

            }
            return true;
        }
    }
}
