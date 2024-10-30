using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskk
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Limit { get; set; }
        public Student[] students = { };

        public Group(int id, string name, int limit)
        {
            Id = id;
            Name = name;
            Limit = limit;
        }
        public void AddStudent(Student student)
        {
            if (students.Length < Limit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }else
            {
                Console.WriteLine(" Bu grupda yerler dolub :(((");
            }

        }
        public void RemoveStudent(int StudentId)
        {
            Student[] newStudent = { };
            Student removedStudent = null;
            foreach (Student st in students)
            {
                if (st.Id != Id)
                {
                    Array.Resize( ref newStudent, newStudent.Length + 1);
                    newStudent[newStudent.Length - 1] = st;
                }
                else
                {
                    removedStudent= st;

                }
                students= newStudent;
                removedStudent = st;
                Console.WriteLine(removedStudent + " is removed");


            }
        }
        public void UpdateStudent(int id,Student student)
        {
            foreach (Student stu in students)
            {
                if(stu.Id != Id)
                {
                    stu.Id = Id;
                    stu.Name = student.Name;
                    stu.LastName = student.LastName;
                    return;
                }
            }
            Console.WriteLine("Bu id ile telebe tapilmadi");

        }
        public void GetStudents()
        {
            foreach(Student st in students)
            {
                Console.WriteLine(st);
            }
        }
    }
}
