using System.Collections.Concurrent;

namespace CustomIndexOF
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Custom custom = new Custom("salam", 'a');
            Console.WriteLine(custom.GetCostum());
        }
    }
}
