﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskkk
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract void Move();
    }
}
