using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] {"Sema","Rasul","Camal"};
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //names = new string[10];
            //names[3] = "Huseyn";
            //Console.WriteLine(names[3]);
            //Console.WriteLine(names[0]);
            List<string> names2= new List<string> {"Sema","Resul","Camal","Huseyn"};
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Reis");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);


        }
    }
}
