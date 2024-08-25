namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, -2, 3, 4, 5 };
            int num = Int32.MaxValue;

            foreach (int i in arr)
            {
                if (i < num)
                {
                    num = i;
                    
                }
                
            }
            Console.WriteLine(num);
        }
    }
}
