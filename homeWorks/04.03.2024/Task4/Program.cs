namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin");
            int num = int.Parse(Console.ReadLine());
            int dividers = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    dividers++;
                    Console.WriteLine(i);
                }
                
            }
            if (dividers != 2)
            {
                Console.WriteLine("murekkeb");
            }
            else
            {
                Console.WriteLine("sade");
            }

        }
    }
}
