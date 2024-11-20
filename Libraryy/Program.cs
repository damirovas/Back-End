namespace Libraryy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static  Library  EnterLibraryDetails()
        {
            Console.WriteLine("Enter Library Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Library limit");
            int limit = int.Parse(Console.ReadLine());
            Library library = new Library(name, limit);
            return library;
        }
        static Worker EnterWorkerDetails()
        {
            Console.WriteLine("Enter Worker FirstName");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Worker LastName");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Worker Position");
            string position = Console.ReadLine();
            Console.WriteLine("Enter Worker Salary");
            int salary = int.Parse(Console.ReadLine());
            Worker worker = new Worker(firstName, lastName, position,salary);
            return worker;
        }
        static Book EnterBookDetails()
        {
            Console.WriteLine("Enter Book Name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Book genre");
            string genre = Console.ReadLine();
            Console.WriteLine("Enter book author");
            string author = Console.ReadLine();
            Console.WriteLine("Enter ");
        }
    }
}
