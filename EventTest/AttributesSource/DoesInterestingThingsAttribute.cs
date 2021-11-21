using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest.AttributesSource
{
    /// <summary>
    /// 对自定义特性类使用特性AttributeUsage，定义自定义特性的适用范围，AllowMultiple限制是否支持多次应用
    /// </summary>
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method,AllowMultiple =false)]
    class DoesInterestingThingsAttribute:Attribute
    {

        public DoesInterestingThingsAttribute(int howManyTimes)
        {
            this.HowManyTimes = howManyTimes;
        }

        public string WhatDoesItDo { get; set; }
        public int HowManyTimes { get; set; }
    }
}
