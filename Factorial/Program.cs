using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int factorial = 1, number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("Factorial of " + number + ": " + factorial);
        }
    }
}
