namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[10];
            int result = EnterChoosens();
            
            while (result != 0)
            {
                switch (result)
                {
                    case 1:
                       Book  book = EnterBookDetails();
                        for (int i = 0; i < books.Length; i++)
                        {
                            if (books[i] is not null) continue;
                            else
                            {
                                books[i] = book;
                                break;
                            }
                        }
                        result = EnterChoosens();
                        break;
                    case 2:
                        foreach(Book b in books)
                        {
                            if (b is null) continue;
                            else
                            {
                                b.GeFullBook();
                            }
                        }
                        result= EnterChoosens(); 
                        break;
                        default :
                        Console.WriteLine("Yanlis secim");
                        result = EnterChoosens();
                        break;
                }
            }
        }
        static int EnterChoosens()
        {
            Console.WriteLine("Press 0 to exit");
            Console.WriteLine("Press 1 to add new book ");
            Console.WriteLine("Press 2 to show added books");
            int result = int.Parse(Console.ReadLine());
            return result;
        }
        static Book EnterBookDetails()
        {
            Console.WriteLine("Enter Book Id ");
            int id= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Book Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Book Genre ");
            string genre = Console.ReadLine();
            Console.WriteLine("Enter book author");
            string author = Console.ReadLine();

            Book book = new Book(id,name,genre,author);
            return book;
        }
    }
}
