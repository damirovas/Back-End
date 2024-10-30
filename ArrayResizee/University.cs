using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ArrayResizee
{
    internal class University : Education
    {
        public University(int id, string name, decimal mingrade, decimal maxgrade) : base(id, name, mingrade, maxgrade)
        {

        }
        public override void Grade()
        {
            
            Console.WriteLine($"University grade interaval  {MinGrade}  {MaxGrade}");
        }
    }
}
