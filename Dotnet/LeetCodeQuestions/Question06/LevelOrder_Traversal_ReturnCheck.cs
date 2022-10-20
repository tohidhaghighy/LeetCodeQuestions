using LeetCodeQuestions.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Question06
{
    // Level Order Traversal Tree 

    public class LevelOrder_Traversal_ReturnCheck
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void LevelOrder_Traversal_Converter(List<int?> first, List<int?> second)
        {
            // Arrange

            var firsttreeNode = ConvertListToTreeNode.GetTree(first);
            var secondtreeNode = ConvertListToTreeNode.GetTree(second);

            var firsttreelist = ConvertListToTreeNode.GetListTree(firsttreeNode);
            var secondtreelist = ConvertListToTreeNode.GetListTree(secondtreeNode);


            // Act
            bool checkvalue = true;
            if (firsttreelist.Count()!=secondtreelist.Count())
            {
                checkvalue = false;
            }
            if (checkvalue==true)
            {
                for (int i = 0; i < firsttreelist.Count(); i++)
                {
                    if (firsttreelist[i].GetValueOrDefault() != secondtreelist[i].GetValueOrDefault())
                    {
                        checkvalue = false;
                    }
                }
            }
            

            // Assert
            Assert.Equal(checkvalue, true);

        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { new List<int?> { 2, 1, 3 }, new List<int?> { 2, 1, 3 } };
            yield return new object[] { new List<int?> { 5, 1, 4, null, null, 3, 6 }, new List<int?> { 5, 1, 4, null, null, 3, 6 } };
            yield return new object[] { new List<int?> { 1 }, new List<int?> { 2, 1, 3 } };
        }
    }
}
