namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < num; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine(" ");
            //}


           for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    if (i == 1 || j==1 || i==num || j == num)
                    {
                        Console.Write(" *");
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
