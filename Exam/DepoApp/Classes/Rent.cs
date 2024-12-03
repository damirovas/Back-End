using DepoApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DepoApp;
using System.Threading.Tasks;

namespace DepoApp.Classes
{
    public class Rent
    {
        private static int _id;
        public int Id { get; set; }
        public int DepoId { get; set; }
        public int CustomerId { get; set; }
        public double RentArea {  get; set; }


        public Rent(int depoid,int customerid,double rentarea)
        {
            DepoId= depoid;
            CustomerId= customerid;
            RentArea= rentarea;

        }
        
    }
}
