using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.ColorBall
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ball ball = new Ball(12, 22, 32, 50);
            ball.Throw();
            ball.Throw();
            ball.Throw();
            ball.Throw();
            int numThrown = ball.NumOfThrown();
            Console.WriteLine($"The number of thrown is: {numThrown}");
        }
    }
}
