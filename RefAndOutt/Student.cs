﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutt
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Student(int id,string name,string lastname)
        {
            Id= id;
            Name= name;
            LastName= lastname;
        }
        public override string ToString()
        {
            return $"{Name} {LastName}";
        }
    }
}
