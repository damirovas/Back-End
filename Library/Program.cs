namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books[] books = new Books[5];
            string result = EnterChoosens();
            while (result != "0")
            {
                switch (result)
                {
                    case "1":
                        (int id, string name, string author, int page) bookdetails = EnterBookDetails();
                        Books book = new Books(bookdetails.id, bookdetails.name, bookdetails.author, bookdetails.page);
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
                        case "2":
                        foreach(Books b in books)
                        {
                            if(b is  null) continue;
                            else
                            {
                                Console.WriteLine(b.GetFullBook());
                            }
                        }
                        result = EnterChoosens();
                        break;
                    default:
                        Console.WriteLine("Ynlis secim etmisiniz");
                        result = EnterChoosens();
                        break;
                }
            }


        }
        static string EnterChoosens()
        {
            Console.WriteLine("Cixis etmek ucun 0 secin");
            Console.WriteLine("Book elave etmek ucun 1 secin");
            Console.WriteLine("Elav edilmis butun book lari gormek ucun 2 secin");
            string result = Console.ReadLine();
            return result;
        }
        static(int,string,string,int) EnterBookDetails()
        {
            Console.WriteLine("Id ni daxil edin"); 
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Book name daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Book author daxil edin");
            string author = Console.ReadLine();
            Console.WriteLine("Book Page daxil edin ");
            int page = int.Parse(Console.ReadLine());

            return(id,name,author,page);

        }
    }
}
