namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string newStr = "";
            foreach(char ch in str)
            {
                if (ch == 'a')
                {
                    newStr += 'b';
                }
                else
                {
                    newStr += ch;
                }
            }
            Console.WriteLine(newStr);
        }
    }
}
