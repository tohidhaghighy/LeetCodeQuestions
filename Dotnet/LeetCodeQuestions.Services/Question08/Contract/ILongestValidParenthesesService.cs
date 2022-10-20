using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Services.Question08.Contract
{
    public interface ILongestValidParenthesesService
    {
        Task<int> LongestValidParentheses_Length(string data);
    }
}
