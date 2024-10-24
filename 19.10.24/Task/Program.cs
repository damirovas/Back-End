namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];
            bool[] isUsed = new bool[8];
            Random ran = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ran.Next(0, 8);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int randomIndex = ran.Next(arr.Length);
                int temp = arr[i];
                arr[i] = arr[randomIndex];
                arr[randomIndex] = temp;
            }
            int[] arr1 = new int[4];
            int[] arr2 = new int[4];
            int inarr1 = 0, inarr2 = 0;
            for (int i = 0; i < arr.Length && inarr1 < 4; i++)
            {
                if (!isUsed[i])
                {
                    arr1[inarr1++] = arr[i];
                    isUsed[i] = true;
                }
            }
            for (int i = 0; i < arr.Length && inarr2 < 4; i++)
            {
                if (!isUsed[i])
                {
                    arr2[inarr2++] = arr[i];
                    isUsed[i] = true;
                }
            }
            Console.WriteLine("ilkin array: " + string.Join(", ", arr));
            Console.WriteLine("arr1: " + string.Join(", ", arr1));
            Console.WriteLine("arr2: " + string.Join(", ", arr2));
        }
    }
}
