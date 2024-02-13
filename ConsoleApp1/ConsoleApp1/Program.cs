using System;

namespace ConsoleApp1
{
    class Program
    {
        static decimal balance = 1000; // Initial balance

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the ATM!");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        Deposit();
                        break;
                    case 3:
                        Withdraw();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: {balance:C}");
        }

        static void Deposit()
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposit successful. Your new balance is: {balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid amount. Deposit failed.");
            }
        }

        static void Withdraw()
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal successful. Your new balance is: {balance:C}");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient funds. Withdrawal failed.");
            }
            else
            {
                Console.WriteLine("Invalid amount. Withdrawal failed.");
            }
        }
    }
}