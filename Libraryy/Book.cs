using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraryy
{
    internal class Book
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Book(string name, string genre, string author, int pageCount)
        {
            Name = name;
            Id = _id++;
            Genre = genre;
            Author = author;
            PageCount = pageCount;
        }
        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Genre:{Genre} Author:{Author} PageCount:{PageCount}";
        }
    }
}
