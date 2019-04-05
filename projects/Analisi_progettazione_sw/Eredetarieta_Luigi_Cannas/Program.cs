using System;

namespace Eredetarieta_Luigi_Cannas
{
    class Program
    {
        static void Main(string[] args)
        {
            var macchina = new StreetVehicle();

            macchina.CurrentSpeed = 200;
            macchina.Wheels = 4;
            macchina.ModelName="fiat";
            macchina.MaxSpeed = 150;
            macchina.PrintInfo();


        }
    }
}
