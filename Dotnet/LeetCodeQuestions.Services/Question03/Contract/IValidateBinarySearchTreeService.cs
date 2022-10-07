using LeetCodeQuestions.Models.Question01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Services.Question03.Contract
{
    public interface IValidateBinarySearchTreeService
    {
        bool ValidBSTTree(TreeNode<int> node, int min, int max);
    }
}
