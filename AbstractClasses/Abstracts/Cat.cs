using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Abstracts
{
    internal class Cat :Animal
    {
        public Cat(string name) :base (name)
        {
            Name = name;
        }
        public override void Move()
        {
            Console.WriteLine("Cats are running");
        }
    }
}
