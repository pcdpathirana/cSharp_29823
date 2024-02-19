using System;
using System.Collections.Generic;

class LibraryBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool Available { get; set; }

    public void BorrowBook()
    {
        if (Available)
        {
            Available = false;
            Console.WriteLine($"\"{Title}\" by {Author} has been borrowed.");
        }
        else
        {
            Console.WriteLine($"\"{Title}\" by {Author} is not available for borrowing.");
        }
    }
}

class LibrarySystem
{
    private List<LibraryBook> books;

    public LibrarySystem()
    {
        books = new List<LibraryBook>();
        // Add book objects to the list here
        books.Add(new LibraryBook { Title = "Madol Duwa", Author = "Martin Wickramasinghe", Available = true });
        books.Add(new LibraryBook { Title = "Amba Yaluwo", Author = "T. B. Ilangaratne", Available = true });
        books.Add(new LibraryBook { Title = "Yuganthaya", Author = "Martin Wickramasinghe", Available = true });
        // ... add more books
    }

    public void DisplayLibraryStatus()
    {
        Console.WriteLine("\nLibrary Status:");
        foreach (var book in books)
        {
            Console.WriteLine($"- {book.Title} by {book.Author} ({(book.Available ? "Available" : "Borrowed")})");
        }
    }

    public void BorrowBook(string bookTitle)
    {
        foreach (var book in books)
        {
            if (book.Title.ToLower() == bookTitle.ToLower())
            {
                if (book.Available)
                {
                    book.BorrowBook();
                }
                else
                {
                    Console.WriteLine($"The book \"{bookTitle}\" is already borrowed.");
                }
                return;
            }
        }
        Console.WriteLine($"The book \"{bookTitle}\" could not be found in the library.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        LibrarySystem library = new LibrarySystem();
        library.DisplayLibraryStatus();

        Console.WriteLine("\nWhich book do you want to borrow? (Enter title)");
        string bookTitle = Console.ReadLine();

        library.BorrowBook(bookTitle);
        library.DisplayLibraryStatus();
    }
}
