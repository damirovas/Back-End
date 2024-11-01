using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal abstract class Animal
    {
        public static int _id;
        public int Id { get;set; }
        public string Name { get; set; }

        public Animal(string name)
        {
            Id =++_id;
            Name = name;
        }
        public abstract void GetAnimal();
        public abstract void Move();

    }
}
