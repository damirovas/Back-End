using System.Collections.Concurrent;

namespace Taskk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = EnterChoosens();
            Group group = null;

            while(result!=0)
            {
                switch (result)
                {
                    case 1:
                        group = EnterGroupDetails();
                        result=EnterChoosens();
                        break;
                     case 2:
                        Student student = EnterStudentDetails();  
                        group?.AddStudent(student);
                        result= EnterChoosens();
                        break;
                    case 3:
                        Console.WriteLine("Silinicek telebenin id sini yazin");
                        int id = int.Parse(Console.ReadLine());
                        group?.RemoveStudent(id);
                        result = EnterChoosens();
                        break;
                    case 4:
                        Console.WriteLine("edit olunacaq telebenin id sini yaz");
                        int updateid = int.Parse((Console.ReadLine()));
                        Student updateStudent = EnterStudentDetails();
                        group?.AddStudent(updateStudent);
                        result = EnterChoosens();
                        break;
                        case 5:
                        group?.GetStudents();
                        result = EnterChoosens();
                        break;
                    default:
                        Console.WriteLine("Yanlis secim");
                        result = EnterChoosens();
                        break;

                }
            }
           
        }
        static int EnterChoosens()
        {
            Console.WriteLine("Press 0 to exit ");
            Console.WriteLine("Press 1 to add new Group");
            Console.WriteLine("Press 2 to add new Student");
            Console.WriteLine("Press 3 to remove Student");
            Console.WriteLine("Press 4 to edit Student");
            Console.WriteLine("Press 5 to show added students");
            int result = int.Parse(Console.ReadLine());
            return result;
        }
        static Group EnterGroupDetails()
        {
            Console.WriteLine("Enter Group Id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Group Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Group Limit");
            int limit = int.Parse(Console.ReadLine());

            Group gr= new Group(id, name, limit);
            return gr;
        }
        static Student EnterStudentDetails()
        {
            Console.WriteLine("Enter Student Id ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student lastName");
            string lastname = Console.ReadLine();
            Student st = new Student(id, name, lastname);
            return st;
        }
    }
}
