using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bike : Vehicle
    {
        public Bike(int speed) : base(speed)
        {
            Speed = speed;
        }
        public override void Move()
        {
            Console.WriteLine($"Bike is moving by {Speed}");
        }
        public override string ToString()
        {
            return $"This is a bike ";
        }
    }
}
