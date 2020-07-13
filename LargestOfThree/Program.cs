using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, max;
            Console.Write("Enter 1st number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter 3rd number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
                max = number1;
            else
                max = number2;

            if(number3 > max)
                max = number3;

            Console.WriteLine("Largest of the three numbers is " + max);
        }
    }
}
