using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            float temp, fahrenheit;
            Console.Write("Enter the temprature in Celsious: ");
            temp = Convert.ToSingle(Console.ReadLine());
            fahrenheit = (temp * 9/5) + 32;
            Console.WriteLine("Temprature in Fahrenheit: " + fahrenheit);
        }
    }
}
