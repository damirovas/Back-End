using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Shapes
{
    internal class Square: Shape
    {
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public Square(decimal width,decimal height)
        {
            Width = width;
            Height = height;
        }

        public override void GetArea()
        {
            decimal area = Width * Height;
            Console.WriteLine(area);
        }

        public override void GetPerimeter()
        {
            decimal perimeter = 2*(Width * Height);
            Console.WriteLine(perimeter);
        }
    }
}
