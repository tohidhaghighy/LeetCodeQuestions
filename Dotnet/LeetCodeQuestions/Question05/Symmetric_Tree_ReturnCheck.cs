using LeetCodeQuestions.Services.Question05.Service;
using LeetCodeQuestions.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Question05
{
    // https://leetcode.com/problems/symmetric-tree/
    // Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).
    public class Symmetric_Tree_ReturnCheck
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void Validate_Binary_Search_Tree_ValideBinarySearchTree(List<int?> tree, bool isvalidtree)
        {
            // Arrange

            var treeNode = ConvertListToTreeNode.GetTree(tree);
            var service = new SymetricTreeService();
            List<int> list = new();
            // Act

            var checkvalidetree = service.isSymmetric(treeNode);

            // Assert
            Assert.Equal(checkvalidetree, isvalidtree);

        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { new List<int?> { 1, 2, 2, 3, 4, 4, 3 }, true };
            yield return new object[] { new List<int?> { 1, 2, 2, null, 3, null, 3 }, false };
            yield return new object[] { new List<int?> { 1 }, true };
            yield return new object[] { new List<int?> { }, true };
        }
    }
}
