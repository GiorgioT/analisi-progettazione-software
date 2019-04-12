using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ereditarieta
{
    public abstract class FlyingVehicle: Vehicle
    {
        protected short directionDegrees;
        protected int altitude;

        public FlyingVehicle()
        {
            altitude = 0;
            directionDegrees = 0;
        }

        public virtual void TakeOff()
        {
            if (altitude == 0)
            {
                Console.WriteLine("Safe your belt. We are taking off");
            }
            while (this.currentSpeed < 100)
            {
                Accelerate(5);
            }
        }

        public virtual void Land()
        {
            if (altitude > 0)
            {
                Console.WriteLine("Captain say you Welcome! We have landed");
            }
        }

        public abstract void TakeOffPianoPiano();
    }
}
