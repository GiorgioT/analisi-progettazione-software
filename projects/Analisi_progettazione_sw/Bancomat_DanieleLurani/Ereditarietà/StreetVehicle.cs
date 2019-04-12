using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarietà
{
    class StreetVehicle:  vehicle
    {
        protected byte wheels;
        public StreetVehicle(byte wheels)
        {
            this.wheels = wheels;
        }
    }
}
