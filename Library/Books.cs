using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Page {  get; set; }

        public Books(int id,string name,string author,int page)
        {
            Id = id;
            Name = name;
            Author = author;
            Page = page;
        }
        public string GetFullBook()
        {
            return $"Name-{Name},Author-{Author},Page-{Page}";
        }
    }
}
