using System;
using System.Collections.Generic;
using System.Text;

namespace Eredetarieta_Luigi_Cannas
{
    class Car : StreetVehicle
    {
        private bool motoreAcceso;
        protected double livelloCarburante;
        


        public void Accendi()
        {
            if ((livelloCarburante > 0))
            {
                motoreAcceso = true;
            }
            
        }

        public bool Spegni()
        {
            return motoreAcceso = false;
        }
        public override void  Accellerate()
        {
            
        }

        public Car()
        {
            wheels = 4;
            livelloCarburante = 100;
            
        }
    }
}
