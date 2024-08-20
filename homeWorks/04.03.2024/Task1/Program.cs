namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eded daxil edin");
            int num = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < num; i++)
            {
                if (i % 2 != 0) continue;
                result += i;
            }
            Console.WriteLine(result);
        }
    }
}
