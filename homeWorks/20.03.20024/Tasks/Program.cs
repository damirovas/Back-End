using System.Threading.Channels;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //int a = 5;
            //int b= 6;
            //a = a + 1;
            //b = a - 1;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion
            ////////////////////////////////////////
            #region Task2
            //int[] arr = new int[] {1,2,3,4,5,6,7,8,9,10,11};
            //Console.WriteLine("Ededi daxil et");
            //int sum = int.Parse(Console.ReadLine());

            //for(int i= 0; i < arr.Length; i++)
            //{
            //    for(int j= i+1;j<arr.Length; j++)
            //    {
            //        if (arr[i] + arr[j] == sum)
            //        {
            //            Console.WriteLine($"{arr[i]} + {arr[j]}=={sum}");
            //        }
            //    }
            //}
            #endregion
            /////////////////////////////////////////////////
            #region Task3
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //int min = Int32.MaxValue;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    for( int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] < arr[j])
            //        {
            //            min = arr[j];
            //            arr[j] = arr[i];
            //            arr[i]=min;
            //        }
            //    }
            //}
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Task4
            //string[] strArr = { "qirmizi", "sari", "yasil", "mavi", "cehrayi", "boz", "sari", "sari", "mavi", "mavi", "mavi", "mavi" };
            //int max = Int32.MinValue;
            //string maxColor = "";
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    int count = 0;

            //    for( int j = 0; j < strArr.Length; j++)
            //    {
            //        if (strArr[i] == strArr[j])
            //        {
            //            count++;
            //        }
            //    }
            //    if(count > max)
            //    {
            //        max = count;
            //        maxColor = strArr[i];
            //    }
            //}
            //Console.WriteLine($"{maxColor}---{max}");

            //string str = string.Join("",strArr);
            //Console.WriteLine(str);
            //char maxChar = ' ';
            //for (int i = 0; i < str.Length; i++)
            //{
            //    int count = 0;

            //    for (int j = i+1; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j])
            //        {
            //            count++;
            //        }
            //    }
            //    if (count > max)
            //    {
            //        max = count;
            //        maxChar = str[i];
            //    }
            //}
            //Console.WriteLine($"{maxChar}---{max}");
            #endregion
            /////////////////////////////////////////////////
            #region Task 5

            //Console.WriteLine("Hundurluyu daxil et");
            //int num = int.Parse(Console.ReadLine());

            //for(int i = 0; i < num; i++)
            //{
            //    int number = 0;
            //    number = number + 1;

            //    for (int j = 0; j < num; j++)
            //    { 

            //        if (i >=j)
            //        { 

            //            Console.Write(number);
            //        }
            //    }
            //    Console.WriteLine();
            //}
            

            #endregion
        }
    }
}
