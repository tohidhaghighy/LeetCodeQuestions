using LeetCodeQuestions.Services.Question10.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Question10
{
    public class MinQueue
    {
        [Theory]
        [InlineData(2, 1)]
        public async void MinQueue_CanEnqueueData(int data, int length)
        {
            // Arrange

            var service = new QueueService();
            // Act

            await service.Enqueue(data);

            // Assert
            Assert.Equal(service.queue.Count, length);

        }

        [Theory]
        [InlineData(2, 1)]
        public async void MinQueue_CanDequeueData(int data, int length)
        {
            // Arrange

            var service = new QueueService();
            // Act

            await service.Enqueue(data);
            await service.Enqueue(data);
            await service.Dequeue();

            // Assert
            Assert.Equal(service.queue.Count, length);

        }

        [Theory]
        [InlineData(2, 2)]
        public async void MinQueue_CanPeekData(int data, int responce)
        {
            // Arrange

            var service = new QueueService();
            // Act

            await service.Enqueue(data);
            var val = await service.Peek();

            // Assert
            Assert.Equal(val, responce);

        }
    }
}
