using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    internal class DataControl <Any> 
            
    {
        public Any[] elements = { };
        //public int[] numbers = { };
        //public string[] words = { };

        //public Fruit[] fruits = { };


        //public void Add(int number)
        //{
        //    Array.Resize(ref numbers, numbers.Length+1);
        //    numbers[numbers.Length-1] = number;
        //}
        //public void Add(string word)
        //{
        //    Array.Resize(ref  words, words.Length+1);
        //    words[words.Length-1] = word;
        //}
        //public void GetStr()
        //{
        //    foreach(string str in words)
        //    {
        //        Console.WriteLine(str);
        //    }
        //}
        //public void Get()
        //{
        //    foreach(int i in numbers)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //public void Add(Fruit fruit)
        //{
        //    Array.Resize(ref fruits,fruits.Length+1);
        //    fruits[fruits.Length - 1] = fruit;
        //}
        //public void GetFruit()
        //{
        //    foreach(Fruit fruit in fruits)
        //    {
        //        Console.WriteLine(fruit);
        //    }
        //}
        public void Add(Any any)
        {
            Array.Resize(ref elements, elements.Length+1);
            elements[elements.Length-1] = any;
        }

        public void Get()
        {
            foreach(Any any in elements)
            {
                Console.WriteLine(any);
            }
        }

        
        
    }
}
