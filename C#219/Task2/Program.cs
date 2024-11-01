using System.Net.Http.Headers;
using Task2.Shapes;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = EnterChoosens();
            while(result != 0)
            {
                if(result == 1 )
                {
                    GetSquare();
                    
                    result=EnterChoosens();

                }else if(result == 2 )
                {
                    GetRectangle1();
                    GetRectangle2();
                    result = EnterChoosens();

                }else if (result == 3 )
                {
                    GetCircle();
                    result= EnterChoosens();
                }
                else
                {
                    Console.WriteLine("Something went wrong");
                    result = EnterChoosens();

                }
            }


        }
        static public int EnterChoosens()
        {
            Console.WriteLine("Press o to exit");
            Console.WriteLine("Press 1 to calculate the area and perimeter of the square");
            Console.WriteLine("Press 2 to calculate the area and perimeter of the rectangle");
            Console.WriteLine("Press 3 to calculate the area and perimeter of the circle");
            int result = int.Parse(Console.ReadLine());
            return result;
        }
         static public Square GetSquare()
        {
            Console.WriteLine("Enter the first side of square");
            decimal first = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second side of square");
            decimal second = decimal.Parse(Console.ReadLine());
            Square square = new Square (first, second);
            square.GetPerimeter();
            square.GetArea();
            return square;
        }
         static public Rectangle GetRectangle1()
        {
            Console.WriteLine("Enter first side of the rectangle");
            decimal first = decimal.Parse (Console.ReadLine());
            Console.WriteLine("Enter second side of the rectangle");
            decimal second = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter third side of the rectangle");
            decimal third = decimal.Parse(Console.ReadLine());
            Rectangle reqtangle = new Rectangle(first, second, third);
            return reqtangle;

        }
        static public Rectangle GetRectangle2()
        {
            Console.WriteLine("Enter Side of the rectangle");
            decimal side = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter height of the rectangle");
            decimal height = decimal.Parse(Console.ReadLine());

            Rectangle rect = new Rectangle(side, height);
            return rect;
        }
         static public Circle GetCircle()
        {
            Console.WriteLine("Enter radius of the circle");
            decimal radius = decimal.Parse(Console.ReadLine());
            Circle circle = new Circle (radius);
            return circle;
        }
    }
}
