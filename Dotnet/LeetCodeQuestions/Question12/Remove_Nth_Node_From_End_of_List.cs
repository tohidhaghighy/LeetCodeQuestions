using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Question12
{
    /// <summary>
    /// Given the head of a linked list, remove the nth node from the end of the list and return its head.
    /// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
    /// </summary>
    public class Remove_Nth_Node_From_End_of_List
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void Remove_Nth_Node_From_End_of_List_RemoveCheck(List<int?> l1,int responce, List<int?> l2)
        {
            // Arrange

            var service = new RemoveNthNodeFromEndofListService();
            List<int> list = new();
            // Act

            var sumallitems = service.Add_Two_Numbers_LinkedList(l1, l2);

            // Assert
            Assert.Equal(sumallitems, responce);

        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { new List<int?> { 2, 1, 3 },2, new List<int?> { 2, 1, 3 } };
            yield return new object[] { new List<int?> { 5, 1, 4, 0, 0, 3, 6 },1, new List<int?> { 2, 1, 3 } };
            yield return new object[] { new List<int?> { 1 },1, new List<int?> { 2, 1, 3 } };
            yield return new object[] { new List<int?> { },0, new List<int?> { 2, 1, 3 } };
        }
    }
}
