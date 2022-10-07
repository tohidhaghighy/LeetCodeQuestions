using LeetCodeQuestions.Services.Question02.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Services.Question02.Service
{
    public class UniqueBinarySearchTreesService : IUniqueBinarySearchTreesService
    {
        // https://www.youtube.com/watch?v=OIc0mHgHUww
        public int CatalanNumber(int n)
        {
            int result = 0;
            // Base case
            if (n <= 1)
            {
                return 1;
            }
            for (int i = 0; i < n; i++)
            {
                result += CatalanNumber(i)
                       * CatalanNumber(n - i - 1);
            }
            return result;
        }
    }
}
