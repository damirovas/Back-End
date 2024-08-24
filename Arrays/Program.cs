using System.Collections.Concurrent;
using System.Security.Claims;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4 };
            //int[] arr2 = new int[4];
            //int[] arr3 = new int[3] { 2, 4, 5 };

            //var arr4 = new int[4] {1,2,3,4};

            //for(int i = arr.Length-1; i >=0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            #region TASK1

            //int[] arr = new int[5] { 1, 2, 3, 4, 5};
            //int result = 0;
            //foreach (int i in arr)
            //{
            //    result += i;
            //}
            //Console.WriteLine(result);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    result += arr[i];
            //}
            //Console.WriteLine(result);
            #endregion

            #region Task2

            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            //int num = Int32.MinValue;

            //foreach (int i in arr) 
            //{
            //    if (i > num)
            //    {
            //        num = i;
            //    }
            //}
            //Console.WriteLine(num);

            #endregion


            //string str = "sema";
            //string newStr = "";
            //foreach (char ch in str) 
            //{
            //    if (ch == 's') continue; newStr += ch;

            //}
            //Console.WriteLine(newStr);

            #region TASK3
            Console.WriteLine("Enter deepth");
            int deepth = int.Parse(Console.ReadLine());

            int a = 1;
            int b = 1;
            
            for(int i = 0; i <= deepth; i++)
            {
                int c = a + b;
                a = b;
                b = c;
               
                Console.WriteLine(c);
            }
           
            #endregion
        }
    }
}
