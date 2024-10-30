using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndBuliders
{
    internal static class Mathematics
    {
        public static int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static void GetSum()
        {
            int result = 0;
            foreach(int i in arr)
            {
                result += i;
            }
            Console.WriteLine(result);
        }

    }
}
