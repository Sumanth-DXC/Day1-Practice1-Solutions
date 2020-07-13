using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NumberOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, safe, count = 0;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            safe = number;
            while(number != 0)
            { 
                number = Convert.ToInt32(number / 10);
                count++;
            }

            number = safe;
            Console.WriteLine("Number of digits in " + number + ": " + count);
        }
    }
}
