namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin");
            int num = int.Parse(Console.ReadLine());
            int power = 0;

           while (num % 2==0)
            {
                power++;
                num/=2;

            }
           if(num!=1)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(power);
            }
        }
    }
}
