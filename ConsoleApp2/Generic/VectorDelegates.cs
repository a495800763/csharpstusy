using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Generic
{
    /// <summary>
    /// 向量的方法委托
    /// </summary>
    public static class VectorDelegates
    {
        //比较两个向量的大小（长度）
        public static int Compare(Vector x,Vector y)
        {
            if (x.R > y.R)
            {
                return 1;
            }
            else if(x.R < y.R)
            {
                return -1;
            }
            return 0;
        }


        //判断一个向量是否在第一象限
        public static bool TopRightQuadrant(Vector target)
        {
            return (target.Theta >= 0.0 && target.Theta <= 90.0);
        }
    }
}
