namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int divider = 0;

            for(int i=1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divider++;
                    
                    Console.WriteLine(i);
                }
                
            }
            Console.WriteLine($"{num} {divider} boleni var");
        }
    }
}
