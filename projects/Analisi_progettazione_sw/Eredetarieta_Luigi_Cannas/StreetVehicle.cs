using System;
using System.Collections.Generic;
using System.Text;

namespace Eredetarieta_Luigi_Cannas
{
    class StreetVehicle:  Vehicle
    {
        protected int wheels;


        public int Wheels { get { return wheels; } set { wheels = value; } }

        public StreetVehicle()
        {
            
                this.wheels=Wheels;
        }
            
    }
}
