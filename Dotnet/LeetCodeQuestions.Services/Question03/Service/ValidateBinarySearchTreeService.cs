using LeetCodeQuestions.Models.Question01;
using LeetCodeQuestions.Services.Question03.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Services.Question03.Service
{
    public class ValidateBinarySearchTreeService: IValidateBinarySearchTreeService
    {
        public bool ValidBSTTree(TreeNode<int> node, int min, int max)
        {
            /* an empty tree is BST */
            if (node == null)
            {
                return true;
            }

            /* false if this node violates the min/max
             * constraints */
            if (node.val < min || node.val > max)
            {
                return false;
            }

            /* otherwise check the subtrees recursively
            tightening the min/max constraints */
            // Allow only distinct values
            return (
                ValidBSTTree(node.left, min, node.val - 1)
                && ValidBSTTree(node.right, node.val + 1, max));
        }
    }
}
