using DepoApp;
using DepoApp.Classes;
using System.Runtime.InteropServices;
namespace DepoApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("SS");
            int result = DepoApp.Classes.BaseStaticClass.EnterChoosens();
            while (result != 0)
            {
                switch (result)
                {
                    case 1:
                        Depot depo = BaseStaticClass.EnterDepoDetails();
                        company.AddDepo(depo);
                        result = BaseStaticClass.EnterChoosens();
                        break;
                    case 2:
                        company.GetDepo();
                        int id = BaseStaticClass.EnterDepoId();
                        depo = company.GetDepoById(id);
                        while (depo is null)
                        {
                            Console.WriteLine("Something went wrong");
                            id = BaseStaticClass.EnterDepoId();
                            depo = company.GetDepoById(id);
                        }
                        Customer customer = BaseStaticClass.EnterCustomerDetails();
                        depo.AddCustomer(customer);
                        result = BaseStaticClass.EnterChoosens();
                        break;
                    case 3:
                        company.GetAllDepos();
                        Console.WriteLine("Depo ID daxil et");
                        int depoid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Musteri id dsxil et");
                        int customerid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Rent olunan area daxil et");
                        double rentarea = double.Parse(Console.ReadLine());
                        Rent rentInfo = Company.GetRent(depoid, customerid, rentarea);
                        if (rentInfo != null)
                        {
                            Console.WriteLine("rent olundu");
                        }
                        else
                        {
                            Console.WriteLine("something went wrong");
                        }
                        result = BaseStaticClass.EnterChoosens();
                        break;
                    case 4:
                        company.GetAllDepos();
                        break;
                    default:
                        result = BaseStaticClass.EnterChoosens();
                        break;
                }
            }
        }
    }
}

