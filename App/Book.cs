using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Book
    {
        private static int _id;
        public int Id { get;set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Book(string genre, string author, int pageCount)
        {
            Id  = _id++;
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
