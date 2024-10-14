using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Car : Vehicle
    {
        public double MotorSize { get; set; }
        public Car(int speed,double motorSize) : base(speed)
        {
            MotorSize = motorSize;
        }
        public override void Move()
        {
            Console.WriteLine($"Car is moving by {Speed}");
        }
        public override string ToString()
        {
            return $"this is a car";
        }
    }
}
