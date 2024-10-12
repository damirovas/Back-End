using System.Collections.Concurrent;
using System.Net;

namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number");
            //int num = int.Parse(Console.ReadLine());

            //for(int i = 0; i < num; i++)
            //{
            //    for(int j = 1 ; j < num-i; j++)
            //    {
            //        Console.Write(" ");

            //    }
            //    for (int k = 0; k <i+1; k++)
            //    {
            //        Console.Write(" *");

            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Enter a number");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 0; i < num; i++)
            //{

            //    for (int j = 1; j < num - i; j++)
            //    {
            //        Console.Write(" ");
            //    }


            //    for (int k = 0; k < i + 1; k++)
            //    {
            //        if (k == 0 || k == i || i == num - 1)
            //        {
            //            Console.Write("* ");  
            //        }
            //        else
            //        {
            //            Console.Write("  ");  
            //        }
            //    }

            //    Console.WriteLine();
            //}
            //Console.WriteLine("Enter a");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter b");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(Sum(a,b));
            Console.WriteLine("enter num ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(findFactorial(num));

        }
        static int findFactorial(int num)
        {
           
            int result = 1;
            for(int i = 1; i <= num; i++)
            {
                result *= num;
            }
            return result;
        }
  }
}
