namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int reverse = 0;

            while (num > 0)
            {
                reverse = reverse * 10 + num % 10;
                num/= 10;
            }
            Console.WriteLine(reverse);
        }
    }
}
