using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "salam";
            //int index = 0;
            //while (str.IndexOf('a',index) != -1)
            //{
            //    index = str.IndexOf("a",index);
            //    Console.WriteLine(index);

            //    index++;
            //}
            //Console.WriteLine("Please enter a string");
            //string str = Console.ReadLine();
            //while(str.Length > 0)
            //{
            //    int count=0;
            //    for(int i=0; i<str.Length; i++)
            //    {
            //        if (str[0] == str[i]) 
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine($"{str[0]}--{count}");
            //    str= str.Replace(str[0].ToString(),string.Empty);
            //}
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            while(str.Length > 0)
            {
                int count = 0;
                for(int i = 0; i < str.Length; i++)
                {
                    if (str[0] == str[i]) count++;
                }
                Console.WriteLine($"{str[0]}--{count}");
                str = str.Replace(str[0].ToString(), string.Empty);

            }
        }
    }
}
