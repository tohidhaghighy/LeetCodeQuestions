using LeetCodeQuestions.Services.Question09.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Question09
{
    public class Min_Stack
    {
        [Theory]
        [InlineData(2, 1)]
        public async void Min_Stack_CanPushData(int data, int length)
        {
            // Arrange

            var service = new MinStackService();
            // Act

            await service.Push(data);

            // Assert
            Assert.Equal(service.stack.Count, length);

        }

        [Theory]
        [InlineData(2, 1)]
        public async void Min_Stack_CanPopData(int data, int length)
        {
            // Arrange

            var service = new MinStackService();
            // Act

            await service.Push(data);
            await service.Push(data);
            await service.Pop();

            // Assert
            Assert.Equal(service.stack.Count, length);

        }

        [Theory]
        [InlineData(2, 2)]
        public async void Min_Stack_CanPeekData(int data, int responce)
        {
            // Arrange

            var service = new MinStackService();
            // Act

            await service.Push(data);
            var val = await service.Peek();

            // Assert
            Assert.Equal(val, responce);

        }
    }
}
