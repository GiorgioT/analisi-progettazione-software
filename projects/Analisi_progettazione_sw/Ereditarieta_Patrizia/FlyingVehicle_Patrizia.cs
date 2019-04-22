using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta_Patrizia
{
    class FlyingVehicle_Patrizia : Vehicle_Patrizia
    {
        protected int altitude;
        protected int directionDegrees;
        protected int inclinationDegrees;

        public FlyingVehicle_Patrizia()
        {
            altitude = 0;
            directionDegrees = 0;
        }
        public void Land()
        {
            
            if(altitude>0)
            {
                while (altitude > 0)
                {
                    altitude -= 1;
                    
                }
                if(altitude == 0 && currentSpeed > 0)

                {
                    while (currentSpeed > 0)
                    {
                        Brake();
                    }
                }
            }
            Console.WriteLine("Captain say you Welcome!!");
        }
        public void TakeOff()
        {
            inclinationDegrees = 15;
            Console.WriteLine("Safe your belt, we are landing");
            while (this.currentSpeed<100)
            {
                Accelerate();
                altitude += 1;
                

            }
            if (altitude >= 100)
                inclinationDegrees = 0;
        }


    }
}
