using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class Car // use the keyword "abstract" to create an AC
    {
        // START SHARED FUNCTIONALITY //
        protected bool _on;
        // _on was private: with protected, classes that inherits from Car can use _on

        public void TurnOnOff()
        {
            _on = !_on;
            Console.WriteLine(_on ? "Car is on" : "Car is off");
        }
        // END SHARED FUNCTIONALITY //

        // NOT SHARED FUNCTIONALITY //
        // DECLARED HERE BUT IMPLEMENTED IN A DIFFERENT WAY IN EACH CLASS
        // this method is going to be implemented directly within each class that inherits from the AB
        public abstract void Drive(); // this is defined specifically in any class
    }
}
