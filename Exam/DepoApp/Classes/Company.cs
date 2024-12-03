using DepoApp;
using DepoApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DepoApp.Classes
{
    public class Company
    {


        public int Id { get; set; }
        public string Name { get; set; }
        //public List<Depot> Depos {  get; set; }=new List<Depot>();
        //public List<Rent> Rents { get; set; } = new List<Rent>();
        static List<Depot> Depos { get; set; } = new List<Depot>();
        static List<Rent> Rents { get; set; } = new List<Rent>();
        public Company(string name)
        {

            Name = name;
        }
        public void GetDepo()
        {
            foreach (Depot depo in Depos)
            {
                Console.WriteLine($"{Id} {Name}");
            }
        }
        public Depot GetDepoById(int id)
        {
            Depot depot = Depos.FirstOrDefault(g => g.Id == id);
            if (depot == null)
            {
                Console.WriteLine("Grup bulunamadı.");
            }
            return depot;
        }
        public void AddDepo(Depot depo)
        {
            Depos.Add(depo);
        }
        public void GetAllDepos()
        {
            foreach (Depot depo in Depos)
            {
                Console.WriteLine(depo);
            }
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
        public static Rent GetRent(int depoid, int customerid, double rentarea)
        {
            
            Depot depo = Depos.FirstOrDefault(d => d.Id == depoid);

            if (depo == null)
            {
                Console.WriteLine("Depo tapilmadi");
                return null;  
            }

         
            if (depo.RemainingArea >= rentarea)
            {
                Rent rent = new Rent(depoid, customerid, rentarea);
                Rents.Add(rent);
                depo.RemainingArea -= rentarea;
                Console.WriteLine($" Qalan yer {depo.RemainingArea} m²");
                return rent; 
            }
            else
            {
                throw new DepoApp.Exceptions.NotEnoughField("Kifayet geder yer yoxdu");
                return null;  
            }
            
          

        


            //public Rent GetRent(int depoId, int customerId)
            //{

            //    return Rents.FirstOrDefault(r => r.DepoId == depoId && r.CustomerId == customerId);
            //}


        }
    }
}
