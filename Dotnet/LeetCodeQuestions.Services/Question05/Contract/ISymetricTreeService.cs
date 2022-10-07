using LeetCodeQuestions.Models.Question01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Services.Question05.Contract
{
    public interface ISymetricTreeService
    {
        bool isSymmetric(TreeNode<int> root);
    }
}
