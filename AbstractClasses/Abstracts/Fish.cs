using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Abstracts
{
    internal class Fish : Animal
    {
        public Fish(string name) : base(name) 
        {
            Name = name;
        }
        public string Name { get; set; }
        public override void Move()
        {
            Console.WriteLine("Fish are swimming");
        }
    }
}
