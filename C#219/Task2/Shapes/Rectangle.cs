using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Shapes
{
    internal class Rectangle : Shape
    {
        public decimal FirstSide { get; set; }
        public decimal Height { get; set; }
        public decimal SecondSide { get; set; }
        public decimal ThirdSide { get; set; }
        

        public Rectangle(decimal first,decimal height)
        {
            FirstSide = first;
            Height = height;
            
        }
        public Rectangle(decimal first,decimal second,decimal third)
        {
            FirstSide=first;
            SecondSide=second;
            ThirdSide=third;
        }

        public override void GetArea()
        {
            decimal area = (FirstSide*Height)/2;
            Console.WriteLine(area);
        }

        public override void GetPerimeter()
        {
            decimal perimeter = FirstSide + SecondSide + ThirdSide;
            Console.WriteLine(perimeter);
        }
    }
}
