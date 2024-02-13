using System;

namespace ConsoleApp1
{
    class Program
    {
        static int GetFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return GetFibonacci(n - 1) + GetFibonacci(n - 2);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(GetFibonacci(i) + " ");
            }
        }
    }
}
