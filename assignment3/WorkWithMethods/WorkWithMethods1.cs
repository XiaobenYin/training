using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.WorkWithMethods
{
    public class WorkWithMethods1
    {
        public static int[] GenerateNumbers(int n)
        {

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }
            return numbers;
        }

        public static int[] Reverse(int[] nums)
        {
            int[] result = new int[nums.Length];
            int j = nums.Length - 1;
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[j];
                j--;
            }
            return result;
        }

        public static void PrintNumbers(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }
        }
    }
}
