using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Math
    {
       public int IndexOff(string Str ,char ch)
        {
            int index = -1;
            for(int i = 0; i < Str.Length; i++)
            {
                if (Str[i] == ch)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
