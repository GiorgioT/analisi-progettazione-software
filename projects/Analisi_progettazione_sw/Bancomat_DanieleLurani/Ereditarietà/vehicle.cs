using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarietà
{
    class vehicle
    {
        protected int _maxSpeed, currentSpeed;
        private int numberOfPassengers, yearBuilt;
        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set { _maxSpeed = value; }
        }
        public string ModelName { get; set; }
        public void accellerate()
        {
           Console.WriteLine("Vehicle acceleration");
           if ( currentSpeed < _maxSpeed)
            {
                currentSpeed += + 1;
            }
        }
        public void brake()
        {
            Console.WriteLine("Vehicle break");
        }
        public void printInfo()
        {
            Console.WriteLine("Modello: {0}, Velocità {1}", ModelName, currentSpeed);
            Console.WriteLine($"Modello: {ModelName}, Velocità {currentSpeed}");
        }

    }
}
