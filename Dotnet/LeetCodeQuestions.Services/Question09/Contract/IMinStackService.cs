using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Services.Question09.Contract
{
    public interface IMinStackService
    {
        Task Push(int data);
        Task<int> Pop();
        Task<int> Peek();
        Task<int> MinValue();
        Task<int> MaxValue();
    }
}
