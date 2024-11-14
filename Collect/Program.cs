namespace Collect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] {"sema","rasul","camal","huseyn"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            names[3] = "Fuad";
            Console.WriteLine(names[3]);

        }
    }
}
