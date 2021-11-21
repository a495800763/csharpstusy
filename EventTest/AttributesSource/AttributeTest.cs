using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest.AttributesSource
{
    class AttributeTest
    {
        public static void Main(string[] args)
        {
            Type classType = typeof(DecoratedClass);
            object[] customAttributes = classType.GetCustomAttributes(true);

            foreach(object customAttribute in customAttributes)
            {
                Console.WriteLine($"Attribute of type {customAttribute} found.");
                DoesInterestingThingsAttribute interestingAttribute = customAttribute as DoesInterestingThingsAttribute;
                if (interestingAttribute != null)
                {
                    Console.WriteLine($"This class does {interestingAttribute.WhatDoesItDo} * {interestingAttribute.HowManyTimes}!!");
                }
            }

            Console.ReadKey();
        }
        
    }
}
