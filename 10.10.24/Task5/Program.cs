namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int result = 1;
            for(int i = 1; i <= num; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
