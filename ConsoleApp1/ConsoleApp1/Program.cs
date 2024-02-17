using System;

namespace ConsoleApp1
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();
            myBook.Title = "Madol Duwa";
            myBook.Author = "Martin Wickramasinghe";

            Console.WriteLine("Title: {0}, Author: {1}", myBook.Title, myBook.Author);
        }
    }
}
