using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Book
    {
        public static int _id;
        public int Id { get;set; }
                
        public string Name { get; set; }

        public Book(string name)
        {
            Id = ++_id;
            Name = name;
        }

    }
}
