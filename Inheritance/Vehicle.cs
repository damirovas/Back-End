using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Vehicle
    {
        public int Speed { get; set; }

        public Vehicle(int speed)
        {
            Speed= speed;
        }
        public virtual void Move()
        {
            Console.WriteLine($"car is moving by {Speed }");
        }
        
    }
}
