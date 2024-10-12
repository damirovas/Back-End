namespace Class_And_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3];
            string result = EnterChoosens();

            while (result != "0")
            {
                switch (result)
                {
                    case "1":
                        (int id, string name, string lastName) persondetails = EnterPersonDetails();
                        Person person = new Person(persondetails.id, persondetails.name, persondetails.lastName);
                        for(int i = 0; i < persons.Length; i++)
                        {
                            if (persons[i] is not  null) continue;
                            else
                            {
                                persons[i] = person;
                                break;
                            }
                        }
                        result= EnterChoosens();
                        break;
                    case "2":
                        foreach (Person per in persons)
                        {
                            if (per is null) continue;
                            else
                            {
                                Console.WriteLine(per.GetFullName());
                            }
                        }
                        result = EnterChoosens();
                        break;

                    default:
                        Console.WriteLine("Yanlis secim etmisiniz");
                        result= EnterChoosens();
                        break;

                }
            }

        }
        static string EnterChoosens()
        {
            Console.WriteLine("Cixis etmek ucun 0 secin");
            Console.WriteLine("Person elave etmak ucun 1 secin");
            Console.WriteLine("Elave edilmis butun personlari gormek ucun 2 secin");
            string result = Console.ReadLine();
            return result;
        }
        static (int,string ,string) EnterPersonDetails()
        {
            Console.WriteLine("ID ni daxil edin");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Name daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("LastName daxil edin");
            string lastName = Console.ReadLine();

            return (id, name, lastName);
        }
    }
}
