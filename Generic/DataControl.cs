using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class DataControl
    {
        public int[] numbers = {};
        public void Add(int number)
        {
            Array.Resize(ref numbers, numbers.Length+1);
            numbers[numbers.Length-1] = number;
        }
        public void Get()
        {
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
