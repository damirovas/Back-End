using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class DataControl <Any1,Any2> 
    {
        //public Any[] elements = { };

        //public void Add(Any any)
        //{
        //    Array.Resize(ref elements, elements.Length+1);
        //    elements[elements.Length-1] = any;
        //}
        //public void Get()
        //{
        //    foreach(Any any in elements)
        //    {
        //        Console.WriteLine(any);
        //    }
        //}

        public Any1[] keys = { };
        public Any2[] values = { };
        public void Add(Any1 key ,Any2 value)
        {
            Array.Resize(ref keys, keys.Length + 1);
            keys[keys.Length - 1] = key;
            Array.Resize(ref values, values.Length + 1);
            values[values.Length - 1] = value;

        }
        public void Get()
        {
            for(int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine($"{keys[i]} {values[i]}");
                
            }
        }
    }
}
