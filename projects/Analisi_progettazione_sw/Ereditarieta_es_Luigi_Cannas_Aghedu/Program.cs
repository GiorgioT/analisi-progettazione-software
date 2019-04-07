using System;

namespace Ereditarieta_es_Luigi_Cannas_Aghedu
{
    class Program
    {
        static void Main(string[] args)
        {
            var aereo = new Airplane();
            aereo.ModelName = "aquila rotta";
            aereo.MaxSpeed = 1000;
            aereo.TakeOff();
            aereo.PrintInfo();
            Console.WriteLine("ooooo");
            aereo.Land();
            Console.WriteLine("eeeee");
            aereo.PrintInfo();



            var macchina = new Car(1000);
            macchina.Wheels = 4;
            macchina.ModelName = "catorcio";
            macchina.PrintInfo();
            macchina.MaxSpeed = 230;
            macchina.Accendi();
            macchina.Accellerate();
            macchina.AccellerateTo(40);
            macchina.PrintInfo();
            macchina.Brake();
            macchina.Spegni();
            macchina.PrintInfo();
        }
    }
}
