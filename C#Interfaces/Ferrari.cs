using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Interfaces
{
    // the class Ferrari (once Car) is going to implement the ICar Interface
    internal class Ferrari : ICar
    {
        // FIELDS
        private bool _on;

        // if we take out this method, it's going to complain and say "Ferrari doesn't implement interface member"
        // IMPORTANT: the set of function members need to have a concrete implementation on the class that is using the Interface for ALL the members
        public void TurnOnOff()
        {
            _on = !_on;
            Console.WriteLine(_on ? "Ferrari is on" : "Ferrari is off");
        }

        public void Drive()
        {
            Console.WriteLine(_on ? "Drive the Ferrari" : "Can't drive the Ferrari");
        }
    }
}
