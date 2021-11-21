using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Collections
{
    public class SupperCow:Cow
    {
        public void Fly()
        {
            Console.WriteLine($"{name} is flying!");
        }

        //public SupperCow(string newName) : base(newName)
        //{

        //}

        public override void MakeANoise()
        {
            Console.WriteLine($"{name} says 'here I come to save the day!'");
        }

    }
}
