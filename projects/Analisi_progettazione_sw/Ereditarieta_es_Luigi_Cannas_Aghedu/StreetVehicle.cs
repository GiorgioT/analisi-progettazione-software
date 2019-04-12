using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta_es_Luigi_Cannas_Aghedu
{
    class StreetVehicle : Vehicle
    {
        protected byte wheels;

        public byte Wheels { get; set; }

        public StreetVehicle()
        {
            this.wheels = Wheels;
        }
        public StreetVehicle(byte wheels)
        {
            this.wheels = wheels;
        }
    }
}




