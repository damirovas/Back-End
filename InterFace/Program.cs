using InterFace.Animals;

namespace InterFace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck("Donald");
            duck.Fly();
            duck.Move();
            duck.Swim();
            duck.Run();

        }
    }
}
