using System;

namespace Ereditarietà
{
    class Program
    {
        static void Main(string[] args)
        {
            var fiatPunto = new StreetVehicle(4);
            fiatPunto.MaxSpeed = 90;
            fiatPunto.ModelName = "Punto";

            fiatPunto.printInfo();

            var polo = new vehicle();

        }
        
    }
}
