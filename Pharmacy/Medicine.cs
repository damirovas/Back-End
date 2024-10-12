using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class Medicine
    {
        int Id { get; set; }
        string Name { get; set; }
        string Producer {  get; set; }
        decimal Price { get; set; }
        public Medicine(int id,string name,string producer,decimal price)
        {
            Id = id;
            Name = name;
            Producer = producer;
            Price = price;
        }

        public string GetFullMed()
        {
            return $"Name--{Name},Producer--{Producer},Price--{Price}";
;        }
    }
}
