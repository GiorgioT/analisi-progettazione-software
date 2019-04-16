using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ereditarieta
{
    public class Car: StreetVehicle
    {
        protected double gasLevel;
        private bool isEngineOn;

        public Car(): base(4)
        {
            gasLevel = 100;
        }

        public void PowerOn()
        {
            if (!isEngineOn && gasLevel > 0)
            {
                isEngineOn = true;
            }
        }

        public void PowerOff()
        {
            if (isEngineOn)
            {
                isEngineOn = false;
            }
        }

        public new void Accelerate()
        {
            Console.WriteLine("Car.Accelerate");
            if (gasLevel > 0 && currentSpeed < _maxSpeed)
            {
                currentSpeed += 2.0;
                gasLevel -= currentSpeed / 10;
            }
        }
    }
}
