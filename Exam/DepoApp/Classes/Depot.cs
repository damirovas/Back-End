using DepoApp;
using DepoApp.Classes;

using System;
using System.Collections.Generic;
using System.Linq;
using DepoApp;
using DepoApp.Classes;
using System.Text;
using System.Threading.Tasks;

namespace DepoApp.Classes
{
    public class Depot
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double RemainingArea { get; set; }
        static List <Customer> Customers { get; set; }=new List<Customer>();
        public Depot(string name,double area)
        {
            Id = ++_id;
            Name = name;
            Area = area;
            RemainingArea = area;
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
        
        public void GetCustomers()
        {
            foreach(Customer customer in Customers)
            {
                Console.WriteLine(customer);
            }
        }
        public void AddCustomer(Customer customer)
        {
            if (RemainingArea == 0)
            {
                throw new Exceptions.NotEnoughField("Bu depoda yer yoxdu!!!");
            }
            else
            {
                Customers.Add(customer);
            }

        }


    }
}
