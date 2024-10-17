﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Abstracts
{
    internal class Bird : Animal 
       
    {
        public Bird(string name) :base(name) 
        {
            Name= name;
        }
        public override void Move()
        {
            Console.WriteLine("Birds are flying");
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
