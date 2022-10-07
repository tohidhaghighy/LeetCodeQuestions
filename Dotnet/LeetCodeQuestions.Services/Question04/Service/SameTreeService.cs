using LeetCodeQuestions.Models.Question01;
using LeetCodeQuestions.Services.Question04.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Services.Question04.Service
{
    public class SameTreeService : ISameTreeService
    {
        public bool CheckSameTree(TreeNode<int> first, TreeNode<int> second)
        {
            // first and second are both null
            if (first == null && second == null) return true;
            // one of p and q is null
            if (second == null || first == null) return false;

            if (first.val != second.val) return false;

            return CheckSameTree(first.right, second.right) &&
                    CheckSameTree(first.left, second.left);
        }
    }
}
