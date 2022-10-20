using LeetCodeQuestions.Services.Question07.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Services.Question07.Service
{
    public class ValidParenthesesService : IValidParenthesesService
    {
        public async Task<Boolean> CheckValidParantheses(string data)
        {
            var openParantheses=new List<string>() { "(","{","[" };
            var closeParantheses=new List<string>() { ")","}","]" };
            var stack=new Stack<string>();
            foreach (var character in data)
            {
                if (openParantheses.Contains(character.ToString()))
                {
                    stack.Push(character.ToString());
                }
                else
                {
                    if (stack.Count()==0)
                    {
                        return false;
                    }
                    var top = stack.Peek();
                    if ((character.ToString()==")" && top=="(")||(character.ToString() == "}" && top == "{")||(character.ToString() == "]" && top == "["))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
