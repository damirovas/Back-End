using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Math
    {
        int[] arr = new int[] { 10, -89, 21, 23, -67 };

        public void GetMin() 
        {
            int min = int.MaxValue;
           for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; i < arr.Length; i++)
                {
                    int swap = arr[i];
                    arr[i] = arr[j];
                    arr[j] = swap;
                }
            }
           foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        

    }
}
