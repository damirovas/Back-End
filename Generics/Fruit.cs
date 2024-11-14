using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Fruit
    {
        private static int id;
        public int Id { get; set; }
        public string Name { get; set; }

        public Fruit(string name)
        {
            Id = ++id;
            Name = name;
        }
        public override string ToString()
        {
            return $"{Id}-{Name}";
        }
    }
}
