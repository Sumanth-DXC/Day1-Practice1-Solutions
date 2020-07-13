using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int number1, number2;
            Console.Write("Enter number 1: ");
			number1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter number 2: ");
			number2 = Convert.ToInt32(Console.ReadLine());
			
			number1 = number1 + number2;
			number2 = number1 - number2;
			number1 = number1 - number2;

            Console.WriteLine("Number 1: " + number1);
            Console.WriteLine("Number 2: " + number2);
		}
	}
}
