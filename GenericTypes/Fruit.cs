using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    internal class Fruit
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }

        public Fruit(string name)
        {
            Id = ++_id;
            Name = name;
        }
        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
