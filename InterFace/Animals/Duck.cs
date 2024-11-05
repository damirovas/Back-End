using InterFace.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace.Animals
{
    internal class Duck : Animal ,Ifly,Imove,Iswimable
    {
        public Duck(string name) : base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} flys");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} moves");

        }

        public void Run()
        {

            Console.WriteLine($"{Name} runs");

        }

        public void Swim()
        {
            Console.WriteLine($"{Name} swims");

        }

        public void Walk()
        {
            Console.WriteLine($"{Name} walks");

        }
    }
}
