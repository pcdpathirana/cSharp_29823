using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a positive integer: ");

            if (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("ERROR: Please enter a positive integer.");
                return;
            }

            int sum = (number * (number + 1)) / 2;

            Console.WriteLine($"The sum of numbers from 1 to {number} is: {sum}");

        }
    }
}
