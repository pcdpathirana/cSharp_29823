using System;
using System.Xml.Schema;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            for (int i=0; i<10; i++)
            {
                Console.WriteLine("Enter a number:- ");
                number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("Even !");
                } else
                {
                    Console.WriteLine("Odd !");
                }
            }


        }
    }
}
