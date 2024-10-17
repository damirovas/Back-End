using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teachers
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int BirthtYear { get; set; }
        public Person(int id,string name,string lastname,int birthyear )
        {
            Id= id;
            Name= name;
            LastName= lastname;
            BirthtYear= birthyear;

        }
        public  virtual string GetTeacher()
        {
            return $"Name--{Name},LastName--{LastName},BirtYear--{BirthtYear}";
        }
    }
}
