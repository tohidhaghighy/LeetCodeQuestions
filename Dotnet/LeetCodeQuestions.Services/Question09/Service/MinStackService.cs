using LeetCodeQuestions.Services.Question09.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Services.Question09.Service
{
    public class MinStackService : IMinStackService
    {
        public List<int> stack;
        private int maxValue;
        private int minValue;
        private int maxIndex;
        public MinStackService()
        {
            stack = new List<int>();
            maxValue=0;
            minValue = 0;
            maxIndex = -1;
        }
        public async Task<int> MaxValue()
        {
            return maxValue;
        }

        public async Task<int> MinValue()
        {
            return minValue;
        }

        public async Task<int> Peek()
        {
            return stack[maxIndex];
        }

        public async Task<int> Pop()
        {
            var value = stack[maxIndex];
            if (stack.Count > 0)
            {
                stack.RemoveAt(maxIndex);
            }
            return value;
        }

        public async Task Push(int data)
        {
            stack.Add(data);
            maxIndex++;
            if (data>maxValue)
            {
                maxValue = data;
            }
            if (data<minValue)
            {
                minValue = data;
            }
        }
    }
}
