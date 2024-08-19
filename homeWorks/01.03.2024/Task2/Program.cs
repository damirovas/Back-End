namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region IF ELSE
            //Console.WriteLine("Ededi daxil edin");
            //int num = int.Parse(Console.ReadLine());
            //if(num < 10)
            //{
            //    Console.WriteLine($"{num} bir regemlidir");

            //}
            //else if (num < 100)
            //{
            //    Console.WriteLine($"{num} iki regemlidir");
            //}
            //else if (num< 1000)
            //{
            //    Console.WriteLine($"{num} uc regemlidir");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlis regem secimi");
            //}
            #endregion

            #region Switch case
            Console.WriteLine("Eded daxil edin");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case < 10:
                    Console.WriteLine($"{num} bir regemlidir");
                    break;
                case < 100:
                    Console.WriteLine($"{num} iki regemlidir");
                    break;
                case < 1000:
                    Console.WriteLine($"{num} uc regemlidir");
                    break;
                default:
                    Console.WriteLine("Yanlis regem secimi");
                    break;
            }
            #endregion

        }
    }
}
