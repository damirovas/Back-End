using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Abstracts
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {

        }
        public override void GetAnimal()
        {
            Console.WriteLine($"{Id} {Name}");
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} cat plays");
        }
    }
}
