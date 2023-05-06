using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Car
    {
        // FIELDS
        private bool _on;

        // METHODS
        public void TurnOnOff()
        {
            _on = !_on;
            Console.WriteLine(_on ? "Car is on" : "Car is off"); // example of ternary operator
        }

        public void Drive()
        {
            Console.WriteLine(_on ? "Drive the car" : "Can drive the car");
        }
    }
}
