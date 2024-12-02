using SchoolApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Teacher
    {
        private static int _id;
        public int Id { get; set;}
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }


        public Teacher(string firstname,string lastname,int subjectid)
        {
            Id =++_id;
            FirstName = firstname;
            LastName = lastname;
            SubjectId= subjectid;
        }
    }
}
