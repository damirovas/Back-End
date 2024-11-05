using Task1.Abstracts;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = EnterChoosens();

            while (result != 0)
            {
                switch (result)
                {
                    case 1:
                        GetCat();
                       
                        result=EnterChoosens();
                        break;
                        case 2:
                        GetDog();
                        result=EnterChoosens();
                        break;
                        case 3:
                        GetBird();
                        result=EnterChoosens();
                        break;
                    default:
                        Console.WriteLine("Something went wrong :((");
                        result= EnterChoosens();
                        break;
                }
            }
        }
        static int EnterChoosens()
        {
            Console.WriteLine("Press o to exit");
            Console.WriteLine("Press 1 to know how the cat moves");
            Console.WriteLine("Press 2 to know how the dog moves");
            Console.WriteLine("Press 3 to know how the bird moves");
            int result = int.Parse(Console.ReadLine());
            return result;
        }
        static Dog GetDog()
        {
            Console.WriteLine("Enter Dog Name");
            string name = Console.ReadLine();
            Dog dog = new Dog(name);
            dog.Move();
            dog.GetAnimal();
            return dog;
        }
        static Bird GetBird()
        {
            Console.WriteLine("Enter Bird Name");
            string name = Console.ReadLine();
            Bird bird = new Bird(name);
            bird.Move();
            bird.GetAnimal();
            return bird ;
        }
        static Cat GetCat()
        {
            Console.WriteLine("Enter Cat Name");
            string name = Console.ReadLine();
            Cat cat = new Cat(name);
            cat.Move();
            cat.GetAnimal();
            return cat;
        }
    }
}
