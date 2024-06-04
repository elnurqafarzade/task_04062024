using System;
using task_04062024.Models;

Library library = new Library();

Book book1 = new Book("Programming", "Author1", 300, 1);
Book book2 = new Book("C# Programming", "Author2", 400, 2);
Book book3 = new Book("Java Programming", "Author3", 350, 3);

library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);

Book[] foundBooks = library.FindAllBooksByName("Programming");
Console.WriteLine("Found Books:");
foreach (Book book in foundBooks)
{
    Console.WriteLine($"Name: {book.Name}, Author: {book.AuthorName}, Page Count: {book.PageCount}, Code: {book.Code}");
}

Book[] booksInRange = library.FindAllBooksByPageCountRange(300, 400);
Console.WriteLine("\nBooks in Range:");
foreach (Book book in booksInRange)
{
    Console.WriteLine($"Name: {book.Name}, Author: {book.AuthorName}, Page Count: {book.PageCount}, Code: {book.Code}");
}

library.RemoveBookByCode("P1");

Console.WriteLine("\nAfter removing book:");
foreach (Book book in booksInRange)
{
    Console.WriteLine($"Name: {book.Name}, Author: {book.AuthorName}, Page Count: {book.PageCount}, Code: {book.Code}");
}

Console.ReadKey();
