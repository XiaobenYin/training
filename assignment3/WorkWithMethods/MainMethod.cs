using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.WorkWithMethods
{
   internal class MainMethod
   {
       static void Main(string[] args)
       {
           /* for question #1 */
           Console.WriteLine("Question#1 - Dealing with Array:");
           int[] numbers = WorkWithMethods1.GenerateNumbers(5);
           Console.WriteLine("The original array is: ");
           WorkWithMethods1.PrintNumbers(numbers);
           int[] reversedArr = WorkWithMethods1.Reverse(numbers);
           Console.WriteLine("\nThe reversed array is: ");
           WorkWithMethods1.PrintNumbers(reversedArr);

           /* for question #2 */
           Console.WriteLine("\nQuestion#2 - Fibonacci Numbers");
           int num = FibonacciProblem.Fibonacci(10);
           Console.WriteLine(num);
           Console.WriteLine();

           Console.WriteLine("First ten Fibonacci numbers: ");
           int[] firstTenFibNum = new int[10];

           for (int i = 0; i < firstTenFibNum.Length; i++)
           {
               firstTenFibNum[i] = FibonacciProblem.Fibonacci(i + 1);
               Console.Write($"{firstTenFibNum[i]} ");
           }
       }
   }
}
