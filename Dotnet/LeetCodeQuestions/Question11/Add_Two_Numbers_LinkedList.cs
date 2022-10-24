using LeetCodeQuestions.Services.Question11.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Question11
{
    /// <summary>
    /// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, 
    /// and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.  
    /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    /// https://leetcode.com/problems/add-two-numbers/
    /// </summary>
    public class Add_Two_Numbers_LinkedList
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void Add_Two_Numbers_LinkedList_CheckSum(List<int?> l1, List<int?> l2 ,int responce)
        {
            // Arrange

            var service = new AddTwoNumbersLinkedListService();
            List<int> list = new();
            // Act

            var sumallitems = service.Add_Two_Numbers_LinkedList(l1, l2);

            // Assert
            Assert.Equal(sumallitems, responce);

        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { new List<int?> { 2, 1, 3 }, new List<int?> { 2, 1, 3 } ,426};
            yield return new object[] { new List<int?> { 5, 1, 4, 0, 0, 3, 6 }, new List<int?> { 2, 1, 3 } , 5140249};
            yield return new object[] { new List<int?> { 1 }, new List<int?> { 2, 1, 3 } ,214};
            yield return new object[] { new List<int?> { }, new List<int?> { 2, 1, 3 } ,213};
        }
    }
}
