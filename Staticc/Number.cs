using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Staticc
{
    internal static class Number
    {
        public static string ReplaceA(this string str)
        {
            string newStr = "";
            foreach (char ch in str)
            {
                if(ch =='a')
                {
                    newStr += 'b';
                }
                else
                {
                    newStr += ch;
                }
            }
            return newStr;

        }
    }
}
