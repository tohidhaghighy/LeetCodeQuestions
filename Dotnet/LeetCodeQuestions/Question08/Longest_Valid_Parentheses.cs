using LeetCodeQuestions.Services.Question08.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Question08
{
    /// <summary>
    /// Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.
    /// </summary>
    public class Longest_Valid_Parentheses
    {
        [Theory]
        [InlineData("()(()",2)]
        [InlineData(")()())", 4)]
        [InlineData("()()()", 6)]
        [InlineData("((", 0)]
        [InlineData("(()((()))", 8)]
        [InlineData(")()()()", 6)]
        [InlineData("(()())()", 8)]
        public async void Longest_Valid_Parentheses_IsOk(string data, int length)
        {
            // Arrange

            var service = new LongestValidParenthesesService();
            List<int> list = new();
            // Act

            var validlength = await service.LongestValidParentheses_Length(data);

            // Assert
            Assert.Equal(validlength, length);

        }
    }
}
