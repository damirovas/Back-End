using System;

namespace TwoDimArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] twoDim=new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 6, 7, 8 } };
            //int result = 0;

            //for (int i = 0; i < twoDim.GetLength(0); i++)
            //{
            //    for(int j = 0; j < twoDim.GetLength(1); j++)
            //    {
            //       if(i+j==twoDim.GetLength(0)-1)
            //        {
            //            result += twoDim[i, j];
            //        }
            //    }

            //}
            //Console.WriteLine(result);

            Console.WriteLine("String daxil et");
            string Str = Console.ReadLine();
            string reverseStr = "";
            for (int i =Str.Length - 1; i >= 0; i--)
            {
                reverseStr += Str[i];
            }
            Console.WriteLine(reverseStr);
        }
    }
}
