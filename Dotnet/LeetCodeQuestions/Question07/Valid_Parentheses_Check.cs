using LeetCodeQuestions.Services.Question07.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Question07
{
    /// <summary>
    /// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    ///
    ///    An input string is valid if:
    ///
    /// 1- Open brackets must be closed by the same type of brackets.
    /// 2- Open brackets must be closed in the correct order.
    /// 3- Every close bracket has a corresponding open bracket of the same type.
    /// 
    /// </summary>
    public class Valid_Parentheses_Check
    {
        [Theory]
        [InlineData("()",true)]
        [InlineData("()[]{}",true)]
        [InlineData("(]",false)]
        [InlineData("[()[{()}]",true)]
        [InlineData("}(){}[]",false)]
        [InlineData("[", false)]
        public async void Valid_Parentheses_Check_IsOk(string data,bool check)
        {
            // Arrange

            var service = new ValidParenthesesService();
            List<int> list = new();
            // Act

            var checkvalidation = await service.CheckValidParantheses(data);

            // Assert
            Assert.Equal(checkvalidation, check);

        }
    }
}
