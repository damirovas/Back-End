namespace Teachers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher[] teachers = new Teacher[20];
            int result = EnterChoosens();
            while(result != 0) 
            {
                switch(result)
                {
                    case 1:
                        (int id, string name, string lastname, int birthyear, string university, string speciazilition) teacherdetails = EnterechDetails();
                        Teacher teacher = new Teacher(teacherdetails.id,teacherdetails.name,teacherdetails.lastname,teacherdetails.birthyear,teacherdetails.university,teacherdetails.speciazilition);
                        for(int i = 0; i < teachers.Length; i++)
                        {
                            if (teachers[i] is not null) continue;
                            else
                            {
                                teachers[i] = teacher;
                                break;
                            }
                        }
                        result= EnterChoosens();
                        break;
                        case 2:
                        {
                            foreach(Teacher tech in teachers) 
                            {
                                if (tech is null) continue;
                                else
                                {
                                    Console.WriteLine(tech.GetTeacher());
                                }
                            }
                        }
                        result = EnterChoosens();
                        break;
                    default:
                        Console.WriteLine("Something gets wrong");
                        result = EnterChoosens();
                        break;
                }
            }
        }
        static int EnterChoosens()
        {
            Console.WriteLine("Cixis etmek ucun 0 secin");
            Console.WriteLine("Teacher elave etmek ucun 1 secin");
            Console.WriteLine("Add olunmus teacherleri gormek ucun 2 secim edin");
            int  result = int.Parse(Console.ReadLine());
            return result;
        }
        static (int,string,string,int,string,string) EnterechDetails()
        {
            Console.WriteLine("Id daxil edin");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Name daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("LastName daxil edin");
            string lastname = Console.ReadLine();
            Console.WriteLine("Birthyear daxil et");
            int birtyear= int.Parse(Console.ReadLine());
            Console.WriteLine("University daxil et");
            string university = Console.ReadLine();
            Console.WriteLine("Specizialition daxil et");
            string specizialition= Console.ReadLine();
            return (id,name,lastname,birtyear,university,specizialition);
        }
    }
}
