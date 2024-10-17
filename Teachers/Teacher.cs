using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teachers
{
    internal class Teacher : Person
    {
        public string University {  get; set; }
        public string Specialization { get; set; }

        public Teacher(int id, string name, string lastname, int birthyear,string university,string specializiation) : base(id, name, lastname, birthyear)
        {
            University = university;
            Specialization = specializiation;

        }
        public override string GetTeacher()
        {
            return $"Name--{Name},LastName--{LastName},University--{University},Specializiation--{Specialization}";

        }
    }
}
