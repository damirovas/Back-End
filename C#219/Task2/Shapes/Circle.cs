using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Shapes
{
    internal class Circle : Shape
    {
        public decimal Radius { get; set; }
        public Circle(decimal radius )
        {
            Radius= radius;
        }
        const decimal pi = 3.14m;
        public override void GetArea()
        {
            
            decimal area = pi * Radius * Radius;
            Console.WriteLine(area);
        }

        public override void GetPerimeter()
        {
            decimal perimeter = 2 * pi * Radius;
            Console.WriteLine(Radius);
        }
    }
}
