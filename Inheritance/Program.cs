namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car(100, 2.4);
            car.Move();
            Console.WriteLine(car);
            Vehicle bike = new Bike(120);
            Console.WriteLine(bike);
            bike.Move();
        }
    }
}
