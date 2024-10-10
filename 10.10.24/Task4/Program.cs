using System.Xml.Schema;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Stringi daxil edin");
            //string Str = Console.ReadLine();
            //for (int i = 0;i<Str.Length;i++)
            //{
            //    int count = 0;

            //    foreach (char c in Str)
            //    {
            //        if (c == Str[i])
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine($"{Str[i]} -- {count}");
            //}
            Console.WriteLine("Stringi daxil edin"); 
            string str = Console.ReadLine();
            while(str.Length>0)
            {
                int count = 0;
                for(int i = 0; i < str.Length; i++)
                {
                    if (str[0] == str[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{str[0]} --{count}");
                str = str.Replace(str[0].ToString(),string.Empty);  
            }
        }
    }
}
