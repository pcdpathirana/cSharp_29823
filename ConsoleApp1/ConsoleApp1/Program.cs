using System;

class Product
{
    public string ProductName { get; set; }
    public decimal Price { get; set; }

    public Product(string productName, decimal price)
    {
        ProductName = productName;
        Price = price;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Price: {Price:C2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product book = new Product("iPhone Back Cover", 12.99m);
        Product shirt = new Product("Curren Watch", 19.95m);
        Product headphones = new Product("Wireless Headphones", 79.99m);

        book.DisplayDetails();
        shirt.DisplayDetails();
        headphones.DisplayDetails();
    }
}
