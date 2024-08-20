namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daxil edin");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ucuncu ededi daxil edin");
            int num3 = int.Parse(Console.ReadLine());
            int num = Int32.MinValue;
            if (num1 > num) num = num1;
            if (num2 > num) num = num2;
            if (num3 > num) num = num3;

            int result = 0;
            while (num>0) 
            {
                result += num % 10;
                num /= 10;

            }
            Console.WriteLine(result);

        }
    }
}
