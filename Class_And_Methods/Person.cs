using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Methods
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Person(int id,string name,string lastName)
        {
            Id= id;
            Name= name;
            LastName= lastName;
        }
        public string GetFullName()
        {
            return $"{Name} {LastName} ";
        }
    }
}
