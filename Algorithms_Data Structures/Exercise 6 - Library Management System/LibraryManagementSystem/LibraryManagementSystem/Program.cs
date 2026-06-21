using System;

class Book
{
    public int BookId;
    public string Title;
    public string Author;

    public Book(int id, string title, string author)
    {
        BookId = id;
        Title = title;
        Author = author;
    }
}

class Program
{
    static Book LinearSearch(Book[] books, string title)
    {
        foreach (Book book in books)
        {
            if (book.Title.Equals(title,
                StringComparison.OrdinalIgnoreCase))
            {
                return book;
            }
        }
        return null;
    }

    static Book BinarySearch(Book[] books, string title)
    {
        int left = 0;
        int right = books.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            int compare =
                string.Compare(
                    books[mid].Title,
                    title,
                    StringComparison.OrdinalIgnoreCase);

            if (compare == 0)
                return books[mid];

            if (compare < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Book[] books =
        {
            new Book(101,"C Programming","Dennis Ritchie"),
            new Book(102,"Data Structures","Mark Allen"),
            new Book(103,"Java Programming","James Gosling"),
            new Book(104,"Python Basics","Guido van Rossum")
        };

        Console.WriteLine("Linear Search:");

        Book result1 =
            LinearSearch(books, "Java Programming");

        if (result1 != null)
        {
            Console.WriteLine(
                $"{result1.BookId} {result1.Title} {result1.Author}");
        }

        Array.Sort(books,
            (a, b) => a.Title.CompareTo(b.Title));

        Console.WriteLine("\nBinary Search:");

        Book result2 =
            BinarySearch(books, "Java Programming");

        if (result2 != null)
        {
            Console.WriteLine(
                $"{result2.BookId} {result2.Title} {result2.Author}");
        }
    }
}
