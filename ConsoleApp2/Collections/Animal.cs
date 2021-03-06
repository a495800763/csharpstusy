using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Collections
{
    public abstract class Animal
    {
        protected string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Animal() => name = "The Animal with no name";

        public Animal(string name) => this.name = name;

        public void Feed() => Console.WriteLine($"{name} has been fed.");

        public abstract void MakeANoise();

    }
}
