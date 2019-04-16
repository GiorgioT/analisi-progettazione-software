using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta_Sara
{
    class Vehicle
    {
        /// <summary>
        /// fields
        /// </summary>
        protected int maxSpeed;
        protected int currentSpeed;
        private int numberOfPassenger;
        private int yearBuilt;
        //properties
        public int MaxSpeed { get; set; }
        public string ModelName { get; set; }
        //methods - operations
        public virtual void Accelerate()
        {
            if (currentSpeed < MaxSpeed)
            {
                Console.WriteLine("Sto accellerando");
                currentSpeed += 1;
            }
        }

        public void Brake()
        {
            if (currentSpeed > 0)
                Console.WriteLine("Sto frenando...");
            currentSpeed -= 1;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Model:{ModelName}, current speed: {currentSpeed}");
        }

    }
}