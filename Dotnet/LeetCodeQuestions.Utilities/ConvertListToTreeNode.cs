using LeetCodeQuestions.Models.Question01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Utilities
{
    public static class ConvertListToTreeNode
    {
        /// <summary>
        /// 
        /// Function to insert nodes in level order
        /// Convert List of Int to Tree [1,null,3,4] to tree
        /// </summary>
        /// <param name="treeList"></param>
        /// <returns></returns>
        public static TreeNode<int> GetTree(List<int?> treeList, int i=0)
        {
            TreeNode<int> root = null;
            // Base case for recursion
            if (i < treeList.Count)
            {
                if (treeList[i] != null)
                {
                    root = new TreeNode<int>(treeList[i].GetValueOrDefault());

                    // insert left child
                    root.left = GetTree(treeList, 2 * i + 1);

                    // insert right child
                    root.right = GetTree(treeList, 2 * i + 2);
                }
                 
            }
            return root;
        }
        /// <summary>
        /// Convert treenode  to list of int Tree [1,null,3,4]
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static List<int?> GetListTree(TreeNode<int> root)
        {
            List<int?> list = new List<int?>();
            Queue<TreeNode<int>> queue = new Queue<TreeNode<int>>();
            queue.Enqueue(root);
            list.Add(root.val);
            while (queue.Count != 0)
            {

                TreeNode<int> currentNode = queue.Dequeue();

                /*Enqueue left child */
                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                    list.Add(currentNode.left.val);
                }
                else
                {
                    list.Add(null);
                }

                /*Enqueue right child */
                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                    list.Add(currentNode.right.val);
                }
                else
                {
                    list.Add(null);
                }
            }
            return list;
        }

    }
}
