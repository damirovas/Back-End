using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayResizee
{
    internal class Education
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal MinGrade { get; set; }
        public decimal MaxGrade { get; set; }
        public Education(int id,string name,decimal mingrade,decimal maxgrade)
        {
            Id= id;
            Name= name;
            MinGrade= mingrade;
            MaxGrade= maxgrade;
        }
        public virtual void  Grade()
        {
            Console.WriteLine($"This scholl grade interval is {MinGrade } {MaxGrade}");
        }
    }
}
