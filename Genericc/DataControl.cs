using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericc
{
    internal class DataControl<Any, Any2> //where Any : class where Any2 : class
    {
        public Any[] keys  = { };
        public Any2[] values = { };
        //public int[] numbers = { };
        //public string[] words = { };    
        //public Fruit[] Fruits = { };
        //public void Add (int number)
        //{
        //    Array.Resize(ref numbers, numbers.Length+1);
        //    numbers[numbers.Length-1] = number;
        //}
        //public void Get()
        //{
        //    foreach (int i in numbers)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //public void Add(string word)
        //{
        //    Array.Resize(ref words, words.Length+1);
        //    words[words.Length-1] = word;
        //}
        //public void Add (Fruit fruit)
        //{
        //    Array.Resize(ref Fruits, Fruits.Length+1);  
        //    Fruits[Fruits.Length-1]= fruit;
        //}
        //public void Add (Any element)
        //{
        //    Array.Resize (ref elements, elements.Length+1);
        //    elements[elements.Length-1] = element;

        //}
        //public void Get()
        //{
        //    foreach (Any element in elements)
        //    {
        //        Console.WriteLine(element);
        //    }
        //}

        public void Add(Any key,Any2 value)
        {
            Array.Resize(ref keys, keys.Length+1);
            keys[keys.Length-1] = key;
            Array.Resize(ref values, values.Length+1);
            values[values.Length-1] = value;

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
