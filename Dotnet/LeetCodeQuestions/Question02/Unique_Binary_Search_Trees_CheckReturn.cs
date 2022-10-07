using LeetCodeQuestions.Services.Question02.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Question02
{
    // https://leetcode.com/problems/unique-binary-search-trees/
    public class Unique_Binary_Search_Trees_CheckReturn
    {
        [Theory]
        [InlineData(1,1)]
        [InlineData(2, 2)]
        [InlineData(3, 5)]
        public void Unique_Binary_Search_Trees_CheckReturn_CatalanNumber(int numberofnode,int numberUniqueBSTTree)
        {
            // Arrange

            var service = new UniqueBinarySearchTreesService();

            // Act

            var catalanResult = service.CatalanNumber(numberofnode);

            // Assert
            Assert.Equal(numberUniqueBSTTree, catalanResult);

        }
    }
}
