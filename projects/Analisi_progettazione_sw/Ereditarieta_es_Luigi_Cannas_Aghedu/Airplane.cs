using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta_es_Luigi_Cannas_Aghedu
{
    class Airplane : FlyingVehicle
    {
        public override void Accellerate()
        {
            Console.WriteLine("Stiamo accellerando");
            if (currentSpeed < maxSpeed)
            {
                currentSpeed += 5;
            }
        }
    }
}

