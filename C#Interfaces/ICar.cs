using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Interfaces
{
    internal interface ICar
    {
        // within the interface we only have the METHOD SIGNATURE and not the implementation
        void TurnOnOff();
        void Drive();
    }
}
