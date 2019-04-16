using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta_Patrizia
{
    class Airplane_Patrizia:FlyingVehicle_Patrizia
    {
        public override void Accelerate()
        {
            Console.WriteLine("Sto accelerando...");
            if (currentSpeed < MaxSpeed)
            {
                currentSpeed += 5;
            }

        }
    }
}
