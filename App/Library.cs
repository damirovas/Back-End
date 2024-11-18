using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Library <Any>
    {
        private static int _id;
        public int Id { get;set; }
        public string Name { get; set; }
        public int Limit { get; set; }
        public Any[] books = { };
        public Any[] workers = { };

        public Library(string Name, int limit)
        {
            Id = ++_id;
            Name = Name;
            Limit = limit;
            
        }
        public override string ToString()
        {

            return $"Id:{Id}  Name:{Name} ";
        }
        public void Add(Any any)
        {
            if (books.Length > Limit)
            {
                Array.Resize(ref books, books.Length + 1);
                books[books.Length - 1] = any;
            }
            else
            {
                Console.WriteLine("This Library is completely full");
            }
           
            Array.Resize(ref  workers, workers.Length + 1);
            workers[workers.Length-1]=any;

        }
        public void Remove(int removeId)
        {
            Any[] newBook = { };
            Any[] newWorker = { };
            foreach(Any b in books)
            {
                if (b.Id != removeId)
                {

                }
             
            }
          
        }
    }
}
