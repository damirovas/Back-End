namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("agacin uzunlugunu geyd et");
            //int agac = int.Parse(Console.ReadLine());

            //for (int i = 0; i < agac; i++)
            //{
            //    for (int j = 0; j < agac - i - 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int s = 0; s < 2 * i + 1; s++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("agacin uzunlugunu daxil edin");
            int num = int.Parse(Console.ReadLine());    
            for(int i = 0; i < num; i++)
            {
                for(int j = 0; j < num-i; j++)
                {
                    Console.Write(" ");
                }
                for(int s= 0; s < i+1; s++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
 }



