namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stringi daxil et:");
            string str= Console.ReadLine();
            int index=-1;
            char ch = 'b';

            for(int i = 0;i<str.Length;i++)
            {
                if(ch== str[i])
                {
                    index= i; break;
                }
            }
            if (index != -1)
            {
                Console.WriteLine($"{str}-de {ch} {index+1} yerdedir ");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
