using LeetCodeQuestions.Services.Question03.Service;
using LeetCodeQuestions.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Question03
{
    // https://leetcode.com/problems/validate-binary-search-tree/
    /// <summary>
    /// A valid BST is defined as follows:
    ///
    /// - The left subtree of a node contains only nodes with keys less than the node's key.
    /// - The right subtree of a node contains only nodes with keys greater than the node's key.
    /// - Both the left and right subtrees must also be binary search trees.
    ///
    /// </summary>
    public class Validate_Binary_Search_Tree_CheckReturn
    {

        [Theory]
        [MemberData(nameof(Data))]
        public void Validate_Binary_Search_Tree_ValideBinarySearchTree(List<int?> tree, bool isvalidtree)
        {
            // Arrange

            var treeNode = ConvertListToTreeNode.GetTree(tree);
            var service = new ValidateBinarySearchTreeService();
            List<int> list = new();
            // Act

            var checkvalidetree = service.ValidBSTTree(treeNode,int.MinValue,int.MaxValue);

            // Assert
            Assert.Equal(checkvalidetree, isvalidtree);

        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { new List<int?> { 2, 1, 3 }, true };
            yield return new object[] { new List<int?> { 5, 1, 4, null, null, 3, 6 }, false };
            yield return new object[] { new List<int?> { 1 }, true };
            yield return new object[] { new List<int?> { }, true };
        }

    }
}
