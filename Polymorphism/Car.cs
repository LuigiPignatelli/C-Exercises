using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class Car
    {
        // START SHARED FUNCTIONALITY //
        protected bool _on;

        public void TurnOnOff()
        {
            _on = !_on;
            Console.WriteLine(_on ? "Car is on" : "Car is off");
        }
        // END SHARED FUNCTIONALITY //

        // NOT SHARED FUNCTIONALITY //
        public abstract void Drive();
    }
}
