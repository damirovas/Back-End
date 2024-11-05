using InterFace.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace.Animals
{
    internal class Cat : Animal ,Imove ,Iswimable
    {
        public Cat(string name) : base(name)
        {
        }

        public void Move()
        {
            Console.WriteLine($"{Name}  moves");
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} swim");

        }

        public void Walk()
        {
            Console.WriteLine($"{Name}  walk");

        }
    }
}
