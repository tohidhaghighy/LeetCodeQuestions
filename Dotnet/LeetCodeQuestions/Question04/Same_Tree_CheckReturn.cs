using LeetCodeQuestions.Services.Question04.Service;
using LeetCodeQuestions.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Question04
{
    // https://leetcode.com/problems/same-tree/
    // Given the roots of two binary trees p and q, write a function to check if they are the same or not.
    // Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.

    public class Same_Tree_CheckReturn
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void Same_Tree_CheckReturn_IsSame(List<int?> first, List<int?> second,bool check)
        {
            // Arrange

            var firsttreeNode = ConvertListToTreeNode.GetTree(first);
            var secondtreeNode = ConvertListToTreeNode.GetTree(second);

            var firsttreelist= ConvertListToTreeNode.GetListTree(firsttreeNode);
            var secondtreelist = ConvertListToTreeNode.GetListTree(secondtreeNode);

            var service = new SameTreeService();

            // Act

            var checkvalidetree = service.CheckSameTree(firsttreeNode,secondtreeNode);

            // Assert
            Assert.Equal(checkvalidetree, check);

        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { new List<int?> { 2, 1, 3 }, new List<int?> { 2, 1, 3 } ,true};
            yield return new object[] { new List<int?> { 5, 1, 4, null, null, 3, 6 }, new List<int?> { 5, 1, 4, null, null, 3, 6 } ,true};
            yield return new object[] { new List<int?> { 1 }, new List<int?> { 2, 1, 3 } ,false};
        }
    }
}
