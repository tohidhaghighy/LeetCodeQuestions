using LeetCodeQuestions.Models.Question01;
using LeetCodeQuestions.Services.Question01.Service;
using LeetCodeQuestions.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Question01
{
    // https://leetcode.com/problems/binary-tree-inorder-traversal/solution/
    public class Binary_Tree_Inorder_Traversal_CheckReturn
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void InorderTraversal_Recursive(List<int?> tree, int responseLength)
        {
            // Arrange
            
            var treeNode = ConvertListToTreeNode.GetTree(tree);
            var service = new TraverseTreeService();
            List<int> list = new();
            // Act

            var inorderList = service.InorderList_Recursive(treeNode,list);

            // Assert
            Assert.Equal(responseLength, inorderList.Count);

        }

        [Theory]
        [MemberData(nameof(Data))]
        public void InorderTraversal_Iterator(List<int?> tree,int responseLength)
        {
            // Arrange

            var treeNode = ConvertListToTreeNode.GetTree(tree);
            var service = new TraverseTreeService();
            List<int> list = new();
            // Act

            var inorderList = service.InorderList_Iterating(treeNode, list);

            // Assert
            Assert.Equal(responseLength, inorderList.Count);

        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { new List<int?> { 1, null, 2, 3 }, 3 };
            yield return new object[] { new List<int?> { 43, 2112 },2 };
            yield return new object[] { new List<int?> { 1 } ,1};
            yield return new object[] { new List<int?> { } ,1};
        }
    }
}
