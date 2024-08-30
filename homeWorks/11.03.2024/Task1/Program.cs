namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ededi daxil et:");
            int num = int.Parse(Console.ReadLine());
            int realNum = num;
            int reverse = 0;
            while (num > 0)
            {
                reverse = reverse * 10 + num % 10;
                num /= 10;
            }

            if (reverse == realNum)
            {
                Console.WriteLine($"{realNum} polindromdur");
            }
            else
            {
                Console.WriteLine($"{realNum} polindromdrom deyil");

            }



        }
    }
}
