using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Collections
{
    public class Person : IComparable
    {
        public string Name;
        public int Age;
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        
        public int CompareTo(object obj)
        {
            if(obj is Person)
            {
                Person otherPerson = (Person)obj;
                return this.Age - otherPerson.Age;
            }
            else
            {
                throw new ArgumentException("Object to compare to is not a Person object");
            }
            
        }
    }
}
