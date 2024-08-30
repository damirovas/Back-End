using System.Runtime.Intrinsics.Arm;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            int sum = 0;
            foreach (int i in arr)
            {
                sum+= i;
            }
            int average = sum/arr.Length;
            Console.WriteLine(average);
        }
    }
}
