using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_04062024.Models
{
    public class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; private set; }

        public Book(string name, string authorName, int pageCount, int bookNumber)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = GenerateCode(name, bookNumber);
        }

        private string GenerateCode(string name, int bookNumber)
        {
            string firstLetter = name.Substring(0, 1).ToUpper();
            return $"{firstLetter}{bookNumber:D2}";
        }
    }

}
