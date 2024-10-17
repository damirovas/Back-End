using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Math
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }
        public int Num4 { get; set; }
        public Math(int num1,int num2,int num3,int num4)
        {
            Num1 = num1;
            Num2 = num2;
            Num3 = num3;
            Num4 = num4;
        }
        public int GetMin()
        {
            int min = int.MaxValue;
            if( Num1 < min ) min = Num1;
            if( Num2 < min ) min = Num2;
            if( Num3 < min ) min = Num3;
            if( Num4 < min ) min = Num4;
            return min;
        }
    }
}
