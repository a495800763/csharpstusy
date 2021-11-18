using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest.EventTestSource
{
    public class Display
    {
        /// <summary>
        /// 使用如下方法来响应事件
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public void displayMessage (object source ,MessageArrivedEventArgs e)
        {
            Console.WriteLine($"Message arrived from :{((Connection)source).Name}");
            Console.WriteLine($"Message arrived:{e.Message}");
        }
    }
}
