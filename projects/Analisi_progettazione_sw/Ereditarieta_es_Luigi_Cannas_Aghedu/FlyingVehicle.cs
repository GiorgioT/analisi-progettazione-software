using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta_es_Luigi_Cannas_Aghedu
{
    abstract class FlyingVehicle : Vehicle
    {
        protected short directionDegree;
        protected double altitude;
        protected int inclinationDegree;
        
        public FlyingVehicle()
        {
            this.directionDegree = 0;
            this.altitude = 0;
        }

        public virtual void TakeOff()
        {
            Console.WriteLine("Scoiattoli e Tardigradi stiamo decollando");
            inclinationDegree = 15;
            while (this.currentSpeed < 200)
            {
                Accellerate();
                altitude += 1;
            }

            if (altitude >= 100)
            {
                inclinationDegree = 0;
            }
        }

        public virtual void Land()
        {

            if (altitude > 0)
            {
                while (altitude != 0)
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
            Console.WriteLine("Scoiattoli e Tardigradi siamo atterrati");
        }
    }
}

