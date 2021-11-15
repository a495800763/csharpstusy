using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Generic
{
    class GeneticTest<T>
    {
        public bool Compare(T op1,T op2)
        {
            //if (op1 == op2)
            //{
            //    //如果不对T类型做出where 限制，则可能的类型不支持==操作符
            //}

            return false;
        }
    }
}
