namespace sumOfdivisors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin");
            int num = int.Parse(Console.ReadLine());
            int result = 0;
            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }
    }
}
