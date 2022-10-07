using LeetCodeQuestions.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.UtilitiesTest
{
    public class ConvertListToTreeNode_CheckFunc
    {

        [Theory]
        [MemberData(nameof(Data))]
        public void ConvertListToTreeNode_CheckFunc_NotNull(List<int?> tree)
        {
            // Arrange

            var treeNode = ConvertListToTreeNode.GetTree(tree);

            // Act

            // Assert
            Assert.NotNull(treeNode);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void ConvertListToTreeNode_CheckFunc_LeftHaveValue(List<int?> tree)
        {
            // Arrange

            var treeNode = ConvertListToTreeNode.GetTree(tree);

            // Act

            // Assert
            Assert.NotNull(treeNode.left);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void ConvertListToTreeNode_CheckFunc_RightHaveValue(List<int?> tree)
        {
            // Arrange

            var treeNode = ConvertListToTreeNode.GetTree(tree);

            // Act

            // Assert
            Assert.NotNull(treeNode.right);
        }

        [Theory]
        [MemberData(nameof(CheckRightData))]
        public void ConvertListToTreeNode_CheckFunc_RightValue_IsOk(List<int?> tree)
        {
            // Arrange

            var treeNode = ConvertListToTreeNode.GetTree(tree);

            // Act

            // Assert
            Assert.Equal(treeNode.right.val,2);
        }

        [Theory]
        [MemberData(nameof(CheckLeftData))]
        public void ConvertListToTreeNode_CheckFunc_LeftValue_IsOk(List<int?> tree)
        {
            // Arrange

            // Act

            var treeNode = ConvertListToTreeNode.GetTree(tree);

            // Assert
            Assert.Equal(treeNode.left.val, 5);
        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { new List<int?> { 1, null, 2, 3 } };
            yield return new object[] { new List<int?> { 43, 2112 } };
            yield return new object[] { new List<int?> { 5, 1, 4, null, null, 3, 6 } };
            yield return new object[] { new List<int?> { 1 } };
            yield return new object[] { new List<int?> { } };
        }

        public static IEnumerable<object[]> CheckRightData()
        {
            yield return new object[] { new List<int?> { 1, null, 2, 3 } };
        }

        public static IEnumerable<object[]> CheckLeftData()
        {
            yield return new object[] { new List<int?> { 1, 5, null, 3 } };
        }
    }
}
