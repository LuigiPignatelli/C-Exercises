using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Person
    {
        private Car _car;

        // Car is called a "lAYER OF ABSTRACTION", meaning that we have a generic class, but we can insert calsses that inherit from it
        // the layer of abstraction is also valid for Interfaces
        public Person(Car car) // this is taken an AC as DI -> Person is dependent to Car in order to be created
        {
            _car = car;
        }

        public void Drive()
        {
            _car.TurnOnOff();
            _car.Drive();
        }
    }
}
