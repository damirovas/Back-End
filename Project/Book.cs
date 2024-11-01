using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public Book(int id,string name,string genre,string author)
        {
            Id = id;
            Name = name;
            Genre = genre;
            Author = author;
        }

        public void GeFullBook ()
        {
            Console.WriteLine($"Name--{Name}  Genre--{Genre}  Author--{Author}");
        }
    }
}
