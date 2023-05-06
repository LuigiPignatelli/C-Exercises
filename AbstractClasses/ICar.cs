    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal interface ICar
    {
        // within the interface we only have the METHOD SIGNATURE and not the implementation
        void TurnOnOff();
        void Drive();

        // DIFFERENCE BETWEEN ABSTRACT CLASSES AND INTERFACE:
        // INTERFACE: only has function definition -> tells you what needs to be implemented
        // can't have: concrete definition, fields, constructor
        // CLASSES can implement multiple INTERFACES

        // ABSTRACT CLASS: has fields, functions may be defined, functions that still need to be defined -> can have concrete definition and fields
        // CLASSES can implement one and only one ABSTRACT CLASS
    }
}
