using LeetCodeQuestions.Services.Question08.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Services.Question08.Service
{
    public class LongestValidParenthesesService : ILongestValidParenthesesService
    {
        public async Task<int> LongestValidParentheses_Length(string data)
        {
            int maxans = 0;
            var stack = new Stack<int>();
            stack.Push(-1);
            for (int i = 0; i < data.Length ; i++)
            {
                if (data[i] == '(')
                {
                    stack.Push(i);
                }
                else
                {
                    stack.Pop();
                    if (stack.Count()==0)
                    {
                        stack.Push(i);
                    }
                    else
                    {
                        maxans = Math.Max(maxans, i - stack.Peek());
                    }
                }
            }
            return maxans;
        }
    }
}
