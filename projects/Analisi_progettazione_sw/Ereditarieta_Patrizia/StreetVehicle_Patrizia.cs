using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta_Patrizia
{
    class StreetVehicle_Patrizia:Vehicle_Patrizia
    {
        protected byte wheels;

        public StreetVehicle_Patrizia(byte wheels)
        {
            this.wheels = wheels;
        }
        
    }
}
