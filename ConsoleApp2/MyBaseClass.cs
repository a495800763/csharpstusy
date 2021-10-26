using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyBaseClass
    {
        public void DoSomeThing()
        {

        }
    }

    public class MyDerivedClass : MyBaseClass
    {
        new public void DoSomeThing()
        {

        }
    }

    public class MyVirtualBaseClass
    {
        public virtual void Dosomething()
        {
            Console.WriteLine("Base imp");
        }
    }

    public class MyVirtualDerivedClass : MyVirtualBaseClass
    {
        new public  void Dosomething()
        {
            Console.WriteLine("Derived imp");
        }
    }

    
}
