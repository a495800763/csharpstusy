using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Collections
{
    /// <summary>
    /// 比较器类
    /// </summary>
    public class PersonCompareName:IComparer
    {
        public static IComparer Default = new PersonCompareName();

        public int Compare(object x, object y)
        {
            if(x is Person && y is Person)
            {
                return Comparer.Default.Compare(((Person)x).Name, ((Person)y).Name);
            }
            else
            {
                throw new ArgumentException("one or both objects to compare to are not Person Object.");
            }
        }
    }
}
