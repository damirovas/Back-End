using SchoolApp;
using System.Reflection.Metadata;

namespace SchoolApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Couse course = new Couse("BDC");
           
            int result = BaseStaticClass.EnterChoosens();
            while (result != 0)
            {
                switch (result)
                {
                    case 1:
                        Group group = BaseStaticClass.EnterGroupDetails();
                        course.Groups.Add(group);
                        result = BaseStaticClass.EnterChoosens();
                        break;
                    case 2:
                        course?.GetGroup();
                        int id = BaseStaticClass.EnterGroupId();
                         group = course.GetGroupById(id);
                        while(group is null)
                        {
                            Console.WriteLine("Something went wrong");
                            id = BaseStaticClass.EnterGroupId();
                            group = course.GetGroupById(id);
                        }
                        
                        try
                        {
                        Student student = BaseStaticClass.EnterStudentDetails();
                        group.AddStudent(student);
                       
                        }
                        catch (SchoolApp.Exceptions.StudentMaxCountException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            result = BaseStaticClass.EnterChoosens();
                        }

                        break;
                    case 3:
                        course.GetGroup();
                        
                         id = BaseStaticClass.EnterGroupId();
                        group = course.GetGroupById(id);
                        while (group is null)
                        {
                            Console.WriteLine("Something went wrong");
                            id = BaseStaticClass.EnterGroupId();
                            group = course.GetGroupById(id);
                        }
                        Subject subject =BaseStaticClass.EnterSubjectDetails(); 
                        group.AddSubject(subject);
                        result = BaseStaticClass.EnterChoosens();

                        break;
                    case 4:
                        course.GetGroup();

                        id = BaseStaticClass.EnterGroupId();
                        group = course.GetGroupById(id);
                        while (group is null)
                        {
                            Console.WriteLine("Something went wrong");
                            id = BaseStaticClass.EnterGroupId();
                            group = course.GetGroupById(id);
                        }
                        
                        Teacher teacher= BaseStaticClass.EnterTeacherDetails(group);
                        group.Teachers.Add(teacher);
                        result = BaseStaticClass.EnterChoosens();
                        break;
                    default:
                        break;


                }

            }

        }

    }
}
