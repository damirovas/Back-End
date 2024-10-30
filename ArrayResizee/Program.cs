using System.Transactions;

namespace ArrayResizee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Education education = new Education(1, "asd", 1, 100);
            education.Grade();
            University BDU = new University(2,"Bdu",1,100);
            BDU.Grade();
            PreSchool school = new PreSchool(1, "vhi", 2, 5);
            school.Grade();

        }        
    }
}
