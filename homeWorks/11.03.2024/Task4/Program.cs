namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stringi daxil et");
            string str= Console.ReadLine();
            string realStr = str;
            string reverseStr = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseStr += str[i];
            }
            if (realStr == reverseStr)
            {
                Console.WriteLine($"{realStr} polindrom stringdir");
            }
            else
            {

                Console.WriteLine($"{realStr} polindrom deyil");

            }
        }
    }
}
