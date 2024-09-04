namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stringi daxil et");
            string str = Console.ReadLine();
            int max = Int32.MinValue;

            for(int i = 0;i<str.Length;i++)
            {
                int count = 0;
                foreach(char c in str)
                {
                    if (c == str[i])
                    {
                        count++;
                    
                    }
                }
               Console.WriteLine($"{str[i]}-{count}");
            }
        }
    }
}
