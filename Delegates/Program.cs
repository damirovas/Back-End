using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Delegates
{
    internal class Program
    {
        public delegate int Math(int num1,int num2);

        static void Main(string[] args)
        {
          Math math = new Math(Sum);
            //math += Diff;
            //math += Multi;

            //math += GetMessage();
            //Console.WriteLine(math(1,8));
            //math += delegate (int num1, int num2)
            //{
            //    Console.WriteLine(num1 * num2 - 10);
            //};

            //math += (num1, num2) =>
            //{
            //    int result = num1 * num2 - 10;
            //    Console.WriteLine(result);
            //    return result;
            //};
            //math(3, 8);
          
            //math += (int num1, int num2) =>
            //{
            //    Console.WriteLine(num1 + num2);
            //};
            


        }
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Multi(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Diff(int num1, int num2)
        {
            return (num1 - num2);
        }
        static int  Divide(int num1, int num2)
        {
            return (num1 / num2);
        }
      
    }
}
