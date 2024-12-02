using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SchoolApp.Exceptions
{
    public class SubjectMaxCredit : Exception
    {
        public SubjectMaxCredit(string message) :base(message)
        {
            
        }
    }
}
