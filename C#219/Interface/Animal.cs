using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal abstract class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract void Move();

    }
}
