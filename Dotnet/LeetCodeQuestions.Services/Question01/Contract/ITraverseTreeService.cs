using LeetCodeQuestions.Models.Question01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Services.Question01.Contract
{
    public interface ITraverseTreeService
    {
        List<int> PreorderList_Recursive(TreeNode<int> tree, List<int> list);
        List<int> InorderList_Recursive(TreeNode<int> tree,List<int> list);
        List<int> InorderList_Iterating(TreeNode<int> tree, List<int> list);
        List<int> PostorderList_Recursive(TreeNode<int> tree, List<int> list);
    }
}
