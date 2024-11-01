using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Library
    {
        public int Id { get; set; }
        public readonly  int _id ;
        public string Name { get; set; }
        public int Limit { get; set; }
        public decimal Price { get; set; }
        Book[] books = { }; 
        public Library(int id,string name,int limit,decimal price)
        {
            _id= ++id;
            Name = name;
            Limit = limit;
            Price = price;

        }
        public void AddBook (Book book) 
        {
            if (books.Length < Limit)
            {
                Array.Resize(ref books, Limit+1);
                books[books.Length-1] = book;
            }
            else
            {

                Console.WriteLine("BU grup uzre yer dolub");
            }
        }
        public void RemoveStudent(int BookId)
        {
            Book[] newBook = { };
            Book removedBook = null;
            foreach(Book b in books)
            {
                if(b.Id!=BookId)
                {
                    Array.Resize(ref newBook, newBook.Length + 1);
                    books[newBook.Length-1] =b;
                }
                else
                {
                    removedBook = b;
                }
                books = newBook;
                Console.WriteLine(removedBook + " silindi");

            }

        }
        public void UpdateStudent(int id,Book book )
        {
            foreach(Book b in books)
            {

                foreach (Book bo in books)
                {
                    if (bo.Id == id)
                    {
                        bo.Id = book.Id;
                        bo.Name = book.Id;
                            
                        return;
                    }
                }
                Console.WriteLine("Bu id li telebe tapilmadi");
            }
        }

    }
}
