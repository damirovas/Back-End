using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayResizee
{
    internal class PreSchool : Education
    {
        public PreSchool(int id, string name, decimal mingrade, decimal maxgrade) : base(id, name, mingrade, maxgrade)
        {
        }
        public override void Grade()
        {
            Console.WriteLine($"Pre school grade inteval is {MaxGrade} {MinGrade }");
        }
    }
}
