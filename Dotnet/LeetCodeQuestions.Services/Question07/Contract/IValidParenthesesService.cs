using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Services.Question07.Contract
{
    public interface IValidParenthesesService
    {
        Task<Boolean> CheckValidParantheses(string data);
    }
}
