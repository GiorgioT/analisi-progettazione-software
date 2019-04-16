using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta_Sara
{
    class StreetVehicle : Vehicle
    {
        protected byte wheels;

        public StreetVehicle(byte wheels)
        {
            this.wheels = wheels;
        }
    }
}
