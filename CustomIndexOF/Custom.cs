using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CustomIndexOF
{
    internal class Custom
    {
        public string Str {  get; set; }
    
        public char Ch { get; set; }
        public Custom(string str,char ch)
        {
            Str = str;
            
            Ch = ch;
        }
        public  string GetCostum()
        {
            int index = -1;
            for(int i = 0; i < Str.Length; i++)
            {
                if (Str[i] == Ch)
                {
                    index = i; break;
                }
                else
                {
                    index = -1;
                }
            }
            return $"{Str} de bu char {index}";
        }
    }
}
