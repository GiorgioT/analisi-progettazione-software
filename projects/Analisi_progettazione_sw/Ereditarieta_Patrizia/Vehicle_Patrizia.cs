using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta_Patrizia
{
    class Vehicle_Patrizia
    {
        protected int _maxSpeed;
        protected int currentSpeed;
        private int numberOfPassenger;
        private int yearBuilt;

        public int MaxSpeed { get; set; }
        public string ModelName { get; set; }


        public virtual void Accelerate()
        {
            Console.WriteLine("Sto accelerando...");
            if (currentSpeed < MaxSpeed)
            {
                currentSpeed += 1;
            }

        }

        public virtual void Brake()
        {
            Console.WriteLine("Sto frenando...");
            if (currentSpeed>0)
            {
                currentSpeed -= 1;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"model:{ModelName}, current speed: {currentSpeed}");

        }
    }
}
