using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolApp;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Student
    {
        private static int _id;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(string firstname,string lastname)
        {
            Id=++_id;
            FirstName= firstname;
            LastName = lastname;
        }
        public override string ToString()
        {
            return $" {Id },{LastName},{FirstName}";
        }

    }
}
