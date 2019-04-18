using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta_Sara
{
    class Airplane : FlyingVehicle
    {
        public override void Accelerate()
        {
            Console.WriteLine("Stiamo accellerando");
            if (currentSpeed < MaxSpeed)
            {
                currentSpeed += 5;
            }
        }
    }
}
