using System;
using System.Collections.Generic;
using System.Text;

namespace Eredetarieta_Luigi_Cannas
{
    class StreetVehicle:  Vehicle
    {
        protected byte wheels;

        public StreetVehicle(byte wheels)
        {
            this.wheels = wheels;
        }
    }
}
