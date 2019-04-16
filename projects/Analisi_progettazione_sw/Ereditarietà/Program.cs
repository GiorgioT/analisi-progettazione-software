using System;

namespace Ereditarieta_Sara
{
    class Program
    {
        static void Main(string[] args)
        {
            var fV = new Airplane();

            fV.MaxSpeed = 1000;
            fV.ModelName = "Airbus 259";
            fV.TakeOff();
            fV.PrintInfo();
            Console.WriteLine("We are flying at 8000 meters");
            fV.Land();
            Console.WriteLine("Welcome");

            fV.PrintInfo();
             
        }
    }
}
