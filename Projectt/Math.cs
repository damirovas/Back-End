using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectt
{
    internal static class Math
    {
        //public static int Sum(params int[] numbers)
        //{
        //    int result = 0;
        //    foreach (int number in numbers)
        //    {
        //        result += number;
        //    }
        //    return result;
        //}

        public static int Power (int num, int pow)
        {
            int result = 1;
            for(int i = 0; i < pow; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
