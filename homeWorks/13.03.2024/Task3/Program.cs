namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stringi daxil et");
            string str = Console.ReadLine();

            int count = 0;

            foreach(char c in str)
            {
                if(c ==' ')
                {
                    count++;
                }
            }
            Console.WriteLine($"cumlede {count+1} soz var");
        }
    }
}
