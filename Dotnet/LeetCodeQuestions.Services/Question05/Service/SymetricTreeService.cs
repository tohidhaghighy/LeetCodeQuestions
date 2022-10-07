using LeetCodeQuestions.Models.Question01;
using LeetCodeQuestions.Services.Question05.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Services.Question05.Service
{
    public class SymetricTreeService: ISymetricTreeService
    {
        private bool isMirrored(TreeNode<int> left, TreeNode<int> right)
        {
            if (left == null && right == null) return true;
            else if (left == null || right == null) return false;

            return (left.val == right.val) && isMirrored(left.left, right.right) && isMirrored(left.right, right.left);
        }
        public bool isSymmetric(TreeNode<int> root)
        {
            return isMirrored(root, root);
        }


    }
}
