using System;
using System.Collections.Generic;
using System.Text;

namespace Eredetarieta_Luigi_Cannas
{
    abstract class FlyingVehicle : Vehicle
    {
        protected short directionDegree;
        protected int altitude;

        public short DirectionDegree { get; set; }
        public int Altitude { get; set; }

        public FlyingVehicle()
        {
            this.directionDegree = DirectionDegree;
            this.altitude = Altitude;
            Console.WriteLine("la rotta è" + directionDegree);
        }

        public virtual void TakeOff()
        {
            if (altitude == 0)
            {
                altitude += 1;
                Console.WriteLine("Scoiattoli e Tardigradi stiamo decollando");
            }
        }

        public virtual void Land()
        {
            if (altitude > 0)
            {
                Console.WriteLine("Scoiattoli e Tardigradi siamo atterrati");
            }
            
        }

    }
}
