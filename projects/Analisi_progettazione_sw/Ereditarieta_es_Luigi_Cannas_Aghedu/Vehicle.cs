using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta_es_Luigi_Cannas_Aghedu
{
    class Vehicle
    {
        protected double maxSpeed;
        protected double currentSpeed;
        private int numberOfPassengers;
        private int yearBuild;

        public double MaxSpeed { get; set; }

        public string ModelName { get; set; }

        public virtual void Accellerate()
        {
            if (currentSpeed < MaxSpeed)
            {
                currentSpeed += 1;
                Console.WriteLine("Accellera - velocità = " + currentSpeed);
            }
        }

        public void Brake()
        {
            if (currentSpeed > 0)
            {
                currentSpeed -= 1;
                Console.WriteLine("Frena - velocità = "+currentSpeed);
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Model: {ModelName}, current speed :{currentSpeed} ");
        }
    }
}
