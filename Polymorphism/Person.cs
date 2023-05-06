using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Person
    {
        // by looking to this code, we cannot say what type of Car we have -> we can only figured that out during runtime
        // Person takes in a DERIVED-CLASS (Ferrari and Lambo) from the BASE-CLASS Car
        // the type of car, captured from the variable (_car), is being figured out during runtime
        // Car can assume many forms here (Ferrari and Lambo)

        private Car _car;

        public Person(Car car) // even though the BASE-CLASS is of type Car, the dependency is Ferrari/Lambo
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
