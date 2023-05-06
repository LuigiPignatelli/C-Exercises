using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Person
    {
        private Car _car; // _car is instantiated and passed in as par, then is assigned to a private field
        public Person(Car car) // Person DEPENDS ON CAR -> can't be created without a car class
        {
            _car = car; // Instantiated and passed in externally, since is a parameter
        }

        // same method of Car Class
        // Use DI to INJECT the Car class as a dependency for the class Person
        public void Drive()
        {
            // methods from Car Class
            _car.TurnOnOff();
            _car.Drive();
        }
    }
}
