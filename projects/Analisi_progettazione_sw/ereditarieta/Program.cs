using System;

namespace ereditarieta
{
    class Program
    {
        static void Main(string[] args)
        {
            var fiatPunto = new StreetVehicle(4);
            fiatPunto.MaxSpeed = 90;
            fiatPunto.ModelName = "Punto";

            fiatPunto.PrintInfo();

            var cesna = new Airplane();
            cesna.ModelName = "Cesna 10447";
            cesna.TakeOff();
            cesna.PrintInfo();
            

            var veic = new Vehicle();


            Vehicle v = new Airplane();
            
        }
    }
}
