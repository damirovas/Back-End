using SchoolApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace SchoolApp
{
   public class BaseStaticClass
    {
        public static int EnterChoosens()
        {
            
            Console.WriteLine("Cixis etmek ucun 0 secim edin");
            Console.WriteLine("Kursa grup elave etmek ucun 1 secim edin ");
            Console.WriteLine("Grupa telebe elave etmek ucun 2 secim edin");
            Console.WriteLine("Fenn elave etmek ucun 3 secim edin");
            Console.WriteLine("Muellim elave etmek ucun 4 secim edin");
            int result = int.Parse(Console.ReadLine());
            return result;
        }
        public static int EnterGroupId()
        {
            Console.WriteLine("Groupun idsini daxil et");
            int groupid= int.Parse(Console.ReadLine());
            return groupid;
        }
        public static Group EnterGroupDetails()
        {
            Console.WriteLine("Qrup adini daxil edin: ");
            string groupName = Console.ReadLine();

            Console.WriteLine("Qrupda ola bilecek max student sayini beyd edin: ");
            int maxStudentCount = int.Parse(Console.ReadLine());

            //return new Group(groupName, maxStudentCount);
            Group group = new Group(groupName,maxStudentCount);
            return group;
        }
        public static Student EnterStudentDetails()
        {
            Console.WriteLine("Enter Student FirstName");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter Student LastName");
            string lastname = Console.ReadLine();
            return new Student(firstname, lastname);    
        }
        public static  Subject EnterSubjectDetails()
        {
            Console.WriteLine("Enter Subject Name");
            string subjectname = Console.ReadLine();
            Console.WriteLine("Enter Subject Credit");
            int subjectcredit= int.Parse(Console.ReadLine());   
            return new Subject(subjectname, subjectcredit);
        }
        
        public static Teacher EnterTeacherDetails(Group group )
        {
            group.GetSubjects();
            Console.WriteLine("Fenni daxil et");
            int subjectId = int.Parse(Console.ReadLine());
            Subject subject = group.GetSubjectById(subjectId);
            while( subject == null )
            {
                Console.WriteLine("Fenn tapilmadi");
                subjectId= int.Parse(Console.ReadLine());
                subject = group.GetSubjectById(subjectId);
            }
            Console.WriteLine("Enter Teacher FirstName");
            string firstname= Console.ReadLine();
            Console.WriteLine("Enter Teacher Lastname");
            string lastname= Console.ReadLine();
            Teacher teacher = new Teacher(firstname, lastname,subjectId);  
            teacher.Subject = subject;
            return teacher;
        }
        //public static Couse Get(Couse couse)
        //{
        //    couse.GetGroup();

        //   int   id = BaseStaticClass.EnterGroupId();
        //    Group group = couse.GetGroupById(id);
        //    while (group is null)
        //    {
        //        Console.WriteLine("Something went wrong");
        //        id = BaseStaticClass.EnterGroupId();
        //        group = couse.GetGroupById(id);
        //    }
        //    return group;
        //}


    }
}
