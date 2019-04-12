using System;

namespace Ereditarieta_Patrizia
{
    class Program
    {
        static void Main(string[] args)
        {
            var veic = new Vehicle_Patrizia();
            
            var fv = new FlyingVehicle_Patrizia();
            fv.MaxSpeed = 1000;
            fv.ModelName = "Airbus 259";
            fv.TakeOff();
            fv.PrintInfo();
            Console.WriteLine("We are flying at 8000 meters");
            fv.Land();
        }
    }
}
