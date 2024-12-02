using SchoolApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Group
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }=new List<Student>();
        public List<Subject> Subjects { get; set; } = new List<Subject>();
        public List<Teacher> Teachers { get; set; }= new List<Teacher> { };
        public int MaxStudentCount { get; set; }
       

        public Group(string name,int maxstudentcount )
        {
            Id=++_id;
            Name=name;
            MaxStudentCount=maxstudentcount;
        }
        public void GetStudents()
        {
            foreach(Student student in Students)
            {
                Console.WriteLine(student);
            }
        }
        public void AddStudent(Student student)
        {
            if (Students.Count >= MaxStudentCount)
            {
                throw new SchoolApp.Exceptions.StudentMaxCountException("Bu grupda yer yoxdu");
            }
            else
            {
                Students.Add(student);
            }

        }
        public void GetSubjects()
        {
            foreach (Subject sub in Subjects)
            {
                Console.WriteLine(sub);
            }
        }
        public void AddSubject(Subject subject)
        {
            int creditMaxCount= Subjects.Sum(x => x.Credit);
            if (creditMaxCount+subject.Credit >= 40) throw new SchoolApp.Exceptions.SubjectMaxCredit("En coxu 40 kreditlik ders ala bilersen");
            else
            {
                Subjects.Add(subject);
            }
        }
        public Subject GetSubjectById(int id)
        {
            return Subjects.FirstOrDefault(x => x.Id == id);
        }
        public void GetTeacher()
        {
            foreach (Teacher teacher in Teachers)
            {
                Console.WriteLine(teacher);
            }
        }

      
    }
}
