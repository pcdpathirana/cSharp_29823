using System;

class BankAccount
{
    public long AccountNumber { get; }
    private decimal Balance { get; set; }

    public BankAccount(long accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid deposit amount. Please enter a positive value.");
        }
        else
        {
            Balance += amount;
            Console.WriteLine("Deposit successful. Updated balance: {0:C}", Balance);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your account number:");
        long accountNumber;
        while (!long.TryParse(Console.ReadLine(), out accountNumber))
        {
            Console.WriteLine("Invalid account number. Please enter a valid number:");
        }

        Console.WriteLine("Enter your initial balance:");
        decimal initialBalance;
        while (!decimal.TryParse(Console.ReadLine(), out initialBalance))
        {
            Console.WriteLine("Invalid initial balance. Please enter a valid number:");
        }

        BankAccount account = new BankAccount(accountNumber, initialBalance);

        Console.WriteLine("Enter the amount to deposit:");
        decimal depositAmount;
        while (!decimal.TryParse(Console.ReadLine(), out depositAmount))
        {
            Console.WriteLine("Invalid deposit amount. Please enter a valid number:");
        }

        account.Deposit(depositAmount);
    }
}
