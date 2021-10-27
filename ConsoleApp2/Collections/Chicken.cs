﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Collections
{
    public class Chicken :Animal
    {
        public void LayEgg() => Console.WriteLine($"{name} has lied an egg.");
        public Chicken(string newName) : base(newName) { }
    }
}
