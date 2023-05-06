using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Interfaces
{
    internal class Person
    {
        // to create a layer of abstraction inseat of using a specifiv Class, like Ferrari or Lamborghini,
        // we use the interface ICar -> the person can accept from any tipe of car and is dependent to any type of car
        private ICar _car;
        public Person(ICar car)
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
