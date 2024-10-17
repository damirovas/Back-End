using AbstractClasses.Abstracts;


namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Bird bird = new Bird("Burhan");
            bird.Move();
            Console.WriteLine(bird);
        }
    }
}
