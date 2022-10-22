using LeetCodeQuestions.Services.Question10.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Services.Question10.Service
{
    public class QueueService: IQueueService
    {
        public List<int> queue;
        private int maxValue;
        private int minValue;
        public QueueService()
        {
            queue = new List<int>();
            maxValue = 0;
            minValue = 0;  
        }

        public async Task<int> Dequeue()
        {
            var value= queue[0];
            if (queue.Count>0)
            {
                queue.RemoveAt(0);
            }
            return value;
        }

        public async Task Enqueue(int data)
        {
            queue.Add(data);
            if (data>maxValue)
            {
                maxValue = data;
            }
            if (data<minValue)
            {
                minValue = data;
            }
        }

        public async Task<int> Peek()
        {
            return queue[0];
        }
    }
}
