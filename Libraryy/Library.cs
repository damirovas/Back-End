using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraryy
{
    internal class Library
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Limit { get; set; }
        public Book[] books = { };
        public Worker[] workers = { };

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
        public void AddBook(Book book)
        {
            if (books.Length > Limit)
            {
                Array.Resize(ref books, books.Length + 1);
                books[books.Length - 1] = book;
            }
            else
            {
                Console.WriteLine("This Libray is completely full");
            }
        }
        public void RemoveBook(int removeId)
        {
            Book[] newBooks = { };
            Book removedBook = null;
            foreach (Book b in books)
            {
                if (b.Id != removeId)
                {
                    Array.Resize(ref newBooks, newBooks.Length + 1);
                    books[newBooks.Length - 1] = b;
                }
                else
                {
                    removedBook = b;
                }
            }
            books = newBooks;
            Console.WriteLine($"{removedBook.Name} has been");
        }
        public void UpdateBook(int id, Book book)
        {
            foreach (Book b in books)
            {
                if (b.Id != id)
                {
                    b.Id = book.Id;
                    b.Name = book.Name;
                    b.Genre = book.Genre;
                    b.Author = book.Author;
                    return;
                }
            }
            Console.WriteLine("not found book with this id");
        }
        public void GetBook()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }
        public void AddWorker(Worker worker)
        {
            Array.Resize(ref workers, workers.Length + 1);
            workers[workers.Length - 1] = worker;
        }
        public void RemoveWorker(int removeId)
        {
            Worker[] newWorker = { };
            Worker removedWorker = null;
            foreach (Worker w in workers)
            {
                if (w.Id != removeId)
                {
                    Array.Resize(ref newWorker, workers.Length + 1);
                    workers[workers.Length - 1] = w;
                }
                else
                {
                    removedWorker = w;
                }
                workers = newWorker;
                removedWorker = w;
                Console.WriteLine($"{removedWorker.LastName} deleted");
            }

        }
        public void UpdateWorker(int id, Worker worker)
        {
            foreach (Worker w in workers)
            {
                if (w.Id != id)
                {
                    w.Id = id;
                    w.FirstName = worker.FirstName;
                    w.LastName = worker.LastName;
                    w.Position = worker.Position;
                    w.Salary = worker.Salary;
                }
                else
                {
                    Console.WriteLine("not found book with this id");
                }
            }
        }
        public void GetWorker()
        {
            foreach (Worker w in workers)
            {
                Console.WriteLine(w);
            }
        }
    }
}
