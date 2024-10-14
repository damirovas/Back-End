namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[10];

            int result = EnterChoosens();
            while(result != 0)
            {
                switch(result)
                {
                    case 1:
                        (int id,string name,string author,int page) bookdetails = EnterBookDetails();
                        Book book = new Book(bookdetails.id,bookdetails.name,bookdetails.author,bookdetails.page);
                        for(int i = 0;i<books.Length;i++)
                        {
                            if (books[i] is not null) continue;
                            else
                            {
                                books[i]=book;
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
                                Console.WriteLine(b.GetFullBook());
                            }
                        }
                        result = EnterChoosens();
                        break;
                    default:
                        Console.WriteLine("Something gets wrong");
                        result = EnterChoosens();
                        break;
                }
            }
        }
        static int EnterChoosens()
        {
            Console.WriteLine("Cixis etemek ucun 0 secin");
            Console.WriteLine("Book add etemek ucun 1 secin");
            Console.WriteLine("Add olunmus booklari gorek ucun 2 secin");
            int result = int.Parse(Console.ReadLine());
            return result;
        }
        static (int,string,string ,int) EnterBookDetails()
        {
            Console.WriteLine("Id elave edin");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Name elave edin");
            string name= Console.ReadLine();
            Console.WriteLine("Author elave et");
            string author = Console.ReadLine();
            Console.WriteLine("Page elave edin");
            int page = int.Parse(Console.ReadLine());
            
            return (id,name,author,page);

        }
    }
}
