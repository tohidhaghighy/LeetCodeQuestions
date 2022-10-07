using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Models.Question01
{
    // Definition for a binary tree node.
    public class TreeNode<T>
    {
        public T val;
        public TreeNode<T> left;
        public TreeNode<T> right;

        public TreeNode(T val , TreeNode<T> left = null, TreeNode<T> right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
