using SchoolApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Subject
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }

        public Subject(string name, int credit)
        {
            Name = name;
            Credit = credit;

        }
        public override string ToString()
        {
            return $"{Id} {Name}";
        }


    }
}
