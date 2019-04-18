using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta_Sara
{
    class FlyingVehicle : Vehicle
    {
        //fields
        protected int altitude;
        protected int inclinationDegrees;
        protected int directionDegrees;
        public FlyingVehicle()
        {
            this.altitude = 0;
            this.directionDegrees = 0;
           
        }

        //methos - operations
        public void TakeOff()
        {
            Console.WriteLine("Safe your belt. we are taking off");
            inclinationDegrees = 15;
            while (this.currentSpeed < 200)
            {
                Accelerate();
                altitude += 1;
               
            }

            if (altitude >= 100)
            {
                inclinationDegrees = 0;
            }

        }
        public void Land()
        {
            if (altitude > 0)

            {
                while (altitude!=0)
                { 
                  altitude -= 1;
                 
             }
                if (currentSpeed > 0)
                {
                    while (currentSpeed > 0)
                    {
                        Brake();
                    }
                      
                }
         }
                Console.WriteLine("Captain say you Welcome!!");
            }

        }
    }

