using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_04062024.Models
{

    public class Library
    {
        private Book[] Books;

        public Library()
        {
            Books = new Book[0];
        }

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        public Book[] FindAllBooksByName(string value)
        {
            return Books.Where(b => b.Name.Contains(value)).ToArray();
        }

        public Book FindBookByCode(string code)
        {
            return Books.FirstOrDefault(b => b.Code == code);
        }

        public Book[] FindAllBooksByPageCountRange(int minPageCount, int maxPageCount)
        {
            return Books.Where(b => b.PageCount >= minPageCount && b.PageCount <= maxPageCount).ToArray();
        }

        public void RemoveBookByCode(string code)
        {
            Books = Books.Where(b => b.Code != code).ToArray();
        }
    }

}
