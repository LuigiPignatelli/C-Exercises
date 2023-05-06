using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Interfaces
{
    // Lamborghini is going to implement the Car Interface ICar
    // Both Ferrari and Lamborghini Class are implementing the Car Interface ICar
    internal class Lambo : ICar
    {
        private bool _on;

        public void TurnOnOff()
        {
            Console.WriteLine(_on ? "Car is on" : "Car is off");
        }
        public void Drive()
        {
            Console.WriteLine(_on ? "Drive the car" : "Can't drive the car");
        }
    }
}
