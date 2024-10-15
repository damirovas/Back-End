namespace _14._10._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[4] { "Sema", "Amma", "Flower", "Regular" };
            for(int i = 0; i <= str.Length; i++)
            {
                if(str.Length+1==i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
