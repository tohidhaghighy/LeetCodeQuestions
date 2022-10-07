using LeetCodeQuestions.Models.Question01;
using LeetCodeQuestions.Services.Question01.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Services.Question01.Service
{
    public class TraverseTreeService : ITraverseTreeService
    {
        // Approach 1: Recursive Approach
        public List<int> InorderList_Recursive(TreeNode<int> tree,List<int> list)
        {
            if (tree!=null)
            {
                if (tree.left!=null)
                {
                    InorderList_Recursive(tree.left, list);
                }
                
                list.Add(tree.val);

                if (tree.right!=null)
                {
                    InorderList_Recursive(tree.right, list);
                }
                   
            }
            return list;
        }

        // Approach 2: Iterating method using Stack
        public List<int> InorderList_Iterating(TreeNode<int> tree, List<int> list)
        {
            Stack<TreeNode<int>> stack = new Stack<TreeNode<int>>();
            TreeNode<int> curr = tree;
            while (curr != null || stack.Count()>0)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Pop();
                list.Add(curr.val);
                curr = curr.right;
            }
            return list;
        }
        // Approach 1: Recursive Approach
        public List<int> PostorderList_Recursive(TreeNode<int> tree, List<int> list)
        {
            if (tree != null)
            {
                if (tree.left!=null)
                {
                    PostorderList_Recursive(tree.left,list);
                }
                if (tree.left != null)
                {
                    PostorderList_Recursive(tree.right,list);
                }
                
                list.Add(tree.val);
            }
            return list;
        }

        // Approach 1: Recursive Approach
        public List<int> PreorderList_Recursive(TreeNode<int> tree, List<int> list)
        {
            if (tree != null)
            {
                list.Add(tree.val);
                if (tree.left!=null)
                {
                    PreorderList_Recursive(tree.left,list);
                }
                if (tree.right!=null)
                {
                    PreorderList_Recursive(tree.right,list);
                }
            }
            return list;
        }
    }
}
