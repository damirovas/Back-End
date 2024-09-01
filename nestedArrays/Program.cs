using System.Globalization;

namespace nestedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[][] jArray = new int[][]
            //{
            //    new int [] { 1, 2, 3, 4, 5},
            //    new int [] { 1, 2}
            //};

            //for(int i = 0; i < jArray.Length; i++)
            //{
            //    Console.Write($"row {i+1} )))) ");
            //    for(int j = 0; j < jArray[i].Length; j++)
            //    {
            //        Console.Write(jArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #region TASK1
            //int[,] arr = new int[4, 4] { { 11, 23, 45, 67 }, 
            //                             { 11, 23, 21, 23 }, 
            //                             { 11, 21, 21, 21 },
            //                             { 11, 21, 21, 32 } };

            //int resultRow = 1;
            //int resultCol = 1;
            //for(int i=0; i<arr.GetLength(0); i++)
            //{
            //    int sumRow = 0;
            //    int sumCol = 0;
            //    for(int j=0; j<arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i,j] + " ");
            //        sumRow += arr[i, j];
            //        sumCol += arr[j, i];    
            //    }
            //    Console.WriteLine();
            //    resultRow*= sumRow;
            //    resultCol*= sumCol;

            //}
            //Console.WriteLine(resultRow);
            //Console.WriteLine(resultCol);

            //if (resultRow > resultCol)
            //{
            //    Console.WriteLine($"{resultRow}> {resultCol} ucun setir uzre hasil sutun uzre hasilden boyukdur");
            //}
            //else
            //{
            //    Console.WriteLine($"{resultRow}< {resultCol} ucun setir uzre hasil sutun uzre hasilden kicikdir");

            //}

            #endregion
            #region TASK2
            //Console.WriteLine("Enter a String ");
            //string str= Console.ReadLine();
            //int max = Int32.MinValue;
            //char ch = ' ';

            //for(int i = 0;i<str.Length;i++)
            //{
            //    int count = 0;
            //    for(int j = 0; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j])
            //        {
            //            count++;
            //        }
            //        if(count> max)
            //        {
            //            max = count;
            //            ch = str[i];
            //        }
            //    }
            //}
            //Console.WriteLine(ch);
            //Console.WriteLine(max);
            #endregion

            #region TASK3
            //Console.WriteLine("Enter string");
            //string str = Console.ReadLine();
            //string newStr = " ";
            //Console.WriteLine("Enter start Index");
            //int startIndex= int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter end Index");
            //int endIndex = int.Parse(Console.ReadLine());

            //if(str.Length>startIndex)
            //{
            //    for(int i = startIndex; i <= endIndex; i++)
            //    {
            //        newStr += str[i];
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("your string is too short");
            //}
            //Console.WriteLine(newStr);
            #endregion

            #region TASK4

            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());    

            for(int i = 1; i <= num; i++)
            {
                for(int j = 1; j <= num; j++)
                {
                    if(i>=j &&( i==num ||  j==1 || i==j))
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine("  ");
            }
            #endregion

        }
    }
}



