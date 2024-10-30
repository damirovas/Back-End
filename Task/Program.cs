using System.Text;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int result = EnterChoosens();
            Group group = null;
            while(result != 0)
            {
                switch (result)
                {
                    case 1:
                        group= EnterGroupDetails();
                        result= EnterChoosens();
                        break;
                     case 2:
                        Student student = EnterStudentDetails();
                        
                        group?.AddStudent(student);
                        result = EnterChoosens();
                        break;
                     case 3:

                        Console.Write("Silinecek telebenin id-sini daxil edin : ");
                        int id = int.Parse(Console.ReadLine());
                        group?.RemoveStudent(id);
                        result = EnterChoosens();
                        break;


                        break;
                     case 4:
                        Console.Write("Deyisilecek telebenin id-sini daxil edin : ");
                        int updateId = int.Parse(Console.ReadLine());
                        Student updatedStudent = EnterStudentDetails();
                        group?.UpdateStudent(updateId, updatedStudent);
                        result = EnterChoosens();
                        break;
                    case 5:
                    
                        group?.GetStudent();
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
            Console.WriteLine("Press 1 to add Group");
            Console.WriteLine("Press 2 to add Student");
            Console.WriteLine("Press 3 to remove Student");
            Console.WriteLine("Press 4 to edit students");
            Console.WriteLine("Press 5 to show Added students");
            int result = int.Parse(Console.ReadLine());
            return result;
        }
        static Group EnterGroupDetails()
        {
            Console.WriteLine("Enter group id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Group Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Group Limit");
            int limit = int.Parse(Console.ReadLine());
            Group gr = new Group(id, name, limit);
            return gr;
        }
        static Student EnterStudentDetails()
        {
            Console.WriteLine("Enter Student Id ");
            int id = int.Parse(Console.ReadLine()) ;
            Console.WriteLine("Enter Student FirstName");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter Student LastName");
            string lastname = Console.ReadLine();
            Student kasib = new Student(id, firstname, lastname);
            return kasib;
        }
     }
 }
  
 