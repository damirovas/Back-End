namespace hollowTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                for(int j = 1; j <= num; j++)
                {
                    if((j==1||i==num)||(j==i))
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    
                }
                Console.WriteLine(" ");
            }
        }
    }
}
