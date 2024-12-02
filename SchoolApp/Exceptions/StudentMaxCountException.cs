using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Exceptions
{
    public class StudentMaxCountException:Exception
    {
        public StudentMaxCountException(string message):base(message) 
        {
          
        }
    }
}
