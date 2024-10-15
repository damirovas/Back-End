namespace Teachers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static int EnterChoosens()
        {
            Console.WriteLine("Cixis etmek ucun 0 secin");
            Console.WriteLine("Teacher elave etmek ucun 2 secin");
            Console.WriteLine("Add olunmus teacherleri gormek ucun 2 secim edin");
            int  result = int.Parse(Console.ReadLine());
            return result;
        }
        static (int,string,string,int,string,string) EnterechDetails()
        {
            Console.WriteLine("Id daxil edin");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Name daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("LastName daxil edin");
            string lastname = Console.ReadLine();
            Console.WriteLine("Birthyear daxil et");
            int birtyear= int.Parse(Console.ReadLine());
            Console.WriteLine("University daxil et");
            string university = Console.ReadLine();


        }
    }
}
