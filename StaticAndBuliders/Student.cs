using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndBuliders
{
    internal class Student
    {
        private static int _id;
        public int Id { get; set;}
        public Student()
        {
            ++_id;
            Id=_id;
        }    
    }
}
