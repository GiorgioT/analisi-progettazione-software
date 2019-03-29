using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarietà
{
    class vehicle
    {
        protected int _maxSpeed, currentSpeed;
        private int numberOfPassengers, yearBuilt;
        public int MaxSpeed { get; set; }
        public string ModelName { get; set; }
        public void accellerate(int time)
        {
           var a = currentSpeed / time;
        }
        public void brake(int time)
        {
            var b = -1 * (currentSpeed / time);
        }
        public void printInfo()
        {
            Console.WriteLine("Modello: {0}, Velocità {1}", ModelName, currentSpeed);
            Console.WriteLine($"Modello: {ModelName}, Velocità {currentSpeed}");
        }

    }
}
