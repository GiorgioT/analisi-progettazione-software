using System;
using System.Collections.Generic;
using System.Text;

namespace Eredetarieta_Luigi_Cannas
{
    class StreetVehicle :  Vehicle
    {
        protected int wheels;


        public int Wheels { get; set; }

        public StreetVehicle()
        {
          
                this.wheels=Wheels;
                 MaxSpeed = 200;
                _currentSpeed = CurrentSpeed;
            
        }
            
    }
}
