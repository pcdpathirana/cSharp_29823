using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter exam marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Error: Marks should be between 0 and 100.");
            }
            else
            {
                string grade;

                if (marks >= 75 && marks <= 100)
                {
                    grade = "A";
                }
                else if (marks >= 60 && marks <= 74)
                {
                    grade = "B";
                }
                else if (marks >= 50 && marks <= 59)
                {
                    grade = "C";
                }
                else if (marks >= 40 && marks <= 49)
                {
                    grade = "D";
                }
                else
                {
                    grade = "Fail";
                }

                Console.WriteLine($"Student Name: {name}");
                Console.WriteLine($"Grade: {grade}");
            }
        }
    }
}