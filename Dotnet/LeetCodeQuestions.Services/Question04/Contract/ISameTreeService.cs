using LeetCodeQuestions.Models.Question01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Services.Question04.Contract
{
    public interface ISameTreeService
    {
        bool CheckSameTree(TreeNode<int> first, TreeNode<int> second);
    }
}
