using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Lambo : Car
    {
        public override void Drive()
        {
            Console.WriteLine(_on ? "Drive the car" : "Can't drive the car");
        }
    }
}
