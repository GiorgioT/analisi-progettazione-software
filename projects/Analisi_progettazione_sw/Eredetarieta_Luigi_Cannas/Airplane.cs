using System;
using System.Collections.Generic;
using System.Text;

namespace Eredetarieta_Luigi_Cannas
{
    class Airplane : FlyingVehicle
    {

        public override void Accellerate()
        {
            Console.WriteLine("Stiamo accellerando");
            if (_currentSpeed < MaxSpeed)
            {
                _currentSpeed += 5;

            }

        }




    }
}
