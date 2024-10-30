using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Group
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Limit { get; set; }
        public Student[] students = {};
        public Group(int id,string name,int limit)
        {
            Id = id;
            Name = name;
            Limit = limit;
        }
        public void AddStudent(Student student) 
        {
            if (students.Length < Limit)
            {
                Array.Resize(ref students, students.Length+1);
                students[students.Length-1] = student;
            }
            else
            {
                Console.WriteLine("Bu grup uzre yer dolub");
            }
        }
        public void RemoveStudent(int StudentId)
        {
            Student[] newStudents = {};
            Student removedStudent= null;
            foreach(Student kasib in students)
            {
                if(kasib.Id != Id)
                {
                    Array.Resize(ref newStudents, newStudents.Length+1);
                    newStudents[newStudents.Length-1] = kasib;
                }
                else
                {
                    removedStudent= kasib;
                }
                students= newStudents;
                Console.WriteLine(removedStudent+" removed");
            }
        }
        public void UpdateStudent( int id,Student student)
        {
            foreach(Student kasib in students)
            {
                if(kasib.Id == id)
                {
                    kasib.Id = student.Id;
                    kasib.FirstName= student.FirstName;
                    kasib.LastName= student.LastName;
                    return;
                }
            }
            Console.WriteLine("Bu id li telebe tapilmadi");
        }
        public void GetStudent ()
        {
            foreach (Student stud in students)
            {
                Console.WriteLine(stud);
            }
        }
    }
}
