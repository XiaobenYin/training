using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.WorkWithMethods
{
    public class FibonacciProblem
    {
        public static int Fibonacci(int num)
        {
            int firstNum = 1;
            int secondNum = 1;
            if (num == 1)
            {
                return firstNum;
            }
            if (num == 2)
            {
                return secondNum;
            }
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }
}
