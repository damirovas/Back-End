using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ling
{
    internal class Product
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public Product(string name,double price,int count)
        {
            Id = ++_id;
            Name=name; Price=price; Count = count;
        }

    }
}
