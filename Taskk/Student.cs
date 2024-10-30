using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskk
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Student(int id,string firstname,string lastname)
        {
            Id = id;
            Name = firstname;
            LastName = lastname;
        }
        public override string ToString()
        {
            return $"Name--{Name} LastName--{LastName}";
        }
    }
}
