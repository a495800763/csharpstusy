using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class GetSetTest
    {
        public readonly string Name;
        private int intVal;
        public int Val
        {
            get
            {
                return intVal;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    intVal = value;
                }
                else
                {
                    throw (new ArgumentOutOfRangeException("Val", value, "Val must be assigned a value between 0 and 10."));
                }
            }
        }

        /// <summary>
        /// 基于表达式的方法：lambda表达式
        /// </summary>
        /// <returns></returns>
        public override string ToString() => "Name:" + Name + "\nVal:" + intVal;

        private GetSetTest() : this("Default Name") { }

        public GetSetTest(string newName)
        {
            Name = newName;
            intVal = 0;
        }

        private int myDoubledInt = 5;
        public int MyDoubledIntProp => (myDoubledInt * 2);
    }
}
