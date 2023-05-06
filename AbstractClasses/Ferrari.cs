using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Ferrari: Car
    {
        // when an AC defines an abstract member, to implement it here, we need to use "override"
        // we're basically overriding a method that is specified in our Car Base Class  
        public override void Drive()
        {
            Console.WriteLine(_on ? "Drive the car" : "Can't drive the car");
        }
    }
}
