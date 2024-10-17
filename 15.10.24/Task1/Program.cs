namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num3");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num4");
            int num4 = int.Parse(Console.ReadLine());
            Math math = new Math (num1,num2,num3,num4);
            Console.WriteLine(math.GetMin());

        }
    }
}
