using LibrarySytstem.Classes;
using System.Text.RegularExpressions;

namespace LibrarySytstem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = EnterChoosens();
            Library library = null;
            Worker worker = null;
            switch (result)
            {

                case 1:
                    library = EnterLibraryDetails();
                    result = EnterChoosens();
                    break;
                case 2:
                    Book book = EnterBookDetails();
                    library?.AddBook(book);
                    result = EnterChoosens();
                break;
                    case 3:
                    library?.GetBook();
                    result = EnterChoosens();   
                    break;
                    case 4:
                    Console.WriteLine("editlenecek id daxil edin");
                    int editId = int.Parse(Console.ReadLine());
                    Book updatedbook = EnterBookDetails();
                    library.AddBook(updatedbook);   
                    result= EnterChoosens();
                    break;
                    case 5:
                    Console.WriteLine("Silinecek book id sini yaz");
                    int removeId = int.Parse(Console.ReadLine());
                    library?.RemoveBook(removeId);
                    result = EnterChoosens();

                    break;
                default:
                    Console.WriteLine("Yanlis secim");
                    result = EnterChoosens();
                    break;
            }





        }
        static int EnterChoosens()
        {
            Console.WriteLine("Press 0 to exit");
            Console.WriteLine("Press 1 to add library");
            Console.WriteLine("Press 2 to ad  book");
            Console.WriteLine("press 3 to see all books");
            Console.WriteLine("press 4 to edit book");
            Console.WriteLine("press 5 to delete book");

            int result = int.Parse(Console.ReadLine());
            return result;
        }
        static Library EnterLibraryDetails()
        {
            Console.WriteLine("enter library name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the limikt of the library");
            int limit = int.Parse(Console.ReadLine());
            Library library = new Library(name, limit);
            return library;

        }
        static Worker EnterWorkerDetails()
        {
            Console.WriteLine("Enter Worker firstName");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter Worker LastName");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter Worker position");
            string position = Console.ReadLine();
            Console.WriteLine("Enter salary");
            double salary = double.Parse(Console.ReadLine());
            Worker worker = new Worker(firstname,lastname,position,salary);
            return worker;
        }
        static Book EnterBookDetails()
        {
            Console.WriteLine("Enter Book Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Book Genre");
            string genre  = Console.ReadLine();
            Console.WriteLine("Enter Book aouthor ");
            string author = Console.ReadLine();
            Console.WriteLine("enter  book count");
            int page = int.Parse(Console.ReadLine());

            Book book = new Book(name,genre,author,page);
            return book;    
        }
    }
}
