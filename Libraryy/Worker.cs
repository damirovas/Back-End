using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraryy
{
    internal class Worker
    {

        private static int _id;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public Worker(string firstname, string lastname, string position, double salary)
        {
            Id = ++_id;
            FirstName = firstname;
            LastName = lastname;
            Position = position;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Id:{Id} FirstName:{FirstName} LastName:{LastName} Position:{Position} Salary:{Salary}";
        }

    }
}
