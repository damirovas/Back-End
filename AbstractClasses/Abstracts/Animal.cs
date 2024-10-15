using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Abstracts
{
    internal abstract class Animal
    {
        protected string Name { get; set; }
        public abstract void Move();
        
        
    }
}
