using System;
using System.Collections.Generic;
using System.Text;

namespace Eredetarieta_Luigi_Cannas
{
    abstract class FlyingVehicle: Vehicle
    {
        protected short directionDegree;
        protected int altitude;

        public FlyingVehicle()
        {
            if (directionDegree > 0)
            {
                Console.WriteLine("Stiamo salendo di quota!!!");

            }else if (directionDegree < 0)
            {
                Console.WriteLine("Stiamo perdendo quota!!!");
            }
            else if ((altitude != 0) && (directionDegree==0))
            {
                Console.WriteLine("Stiamo mantendo la stessa quota!!!");
            }
        }

        public virtual void TakeOff()
        {
            if (altitude > 0)
            {
                Console.WriteLine("Scoiattoli e Tardigradi stiamo decollando");
            }
        }

        public virtual void Land()
        {
            if (altitude == 0)
            {
                Console.WriteLine("Scoiattoli e Tardigradi siamo atterrati");
            }
            
        }

    }
}
