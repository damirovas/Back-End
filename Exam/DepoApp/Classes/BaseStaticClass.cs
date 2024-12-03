using DepoApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DepoApp.Classes
{
    public class BaseStaticClass
    { 
        public static int EnterChoosens()
        {
            Console.WriteLine("Cixis etemek ucun 0 secim edin");
            Console.WriteLine("Company'e Depo elave etmek ucun 1 secim edin");
            Console.WriteLine("Depo'ya Customer elave etmek ucun 2 secim edin");
            Console.WriteLine("REnt etmek ucun 3 secim edin");

            Console.WriteLine("Elave olunmus depolari gormek ucun 4 secim edin");

            int result= int.Parse(Console.ReadLine());
            return result;
        }
        public static int EnterDepoId()
        {
            Console.WriteLine("Depo id'sini daxil edin");
            int depoid= int.Parse(Console.ReadLine());  
            return depoid;
        }
        public static Depot EnterDepoDetails()
        {
            Console.WriteLine("Depo adini daxil edin");
            string deponame= Console.ReadLine();
            Console.WriteLine("Deponun umumi sahesini daxil edin");
            double depoarea= double.Parse(Console.ReadLine());
            Depot depot = new Depot(deponame, depoarea);
            return depot;
        }
        public static Customer EnterCustomerDetails()
        {
            Console.WriteLine("Customer FirstName daxil edin");
            string cfirstname= Console.ReadLine();
            Console.WriteLine("Customer LastName daxil edin");
            string clastname= Console.ReadLine();
            Console.WriteLine("Enter Customer Mail");
            string mail = Console.ReadLine();
            Customer customer = new Customer(cfirstname,clastname,mail);
            return customer;

        }

    }
}
