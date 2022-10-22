using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Services.Question10.Contract
{
    public interface IQueueService
    {
        Task Enqueue(int data);
        Task<int> Dequeue();
        Task<int> Peek();
    }
}
