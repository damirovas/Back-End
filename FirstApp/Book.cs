using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Book
    {
        public int Id {  get; set; }
        public readonly int _id;
        public string Genre { get; set; }
        public string Author { get; set; }
    }
}
