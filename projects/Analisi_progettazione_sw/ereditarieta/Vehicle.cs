using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ereditarieta
{
    public class Vehicle
    {
        //fields
        private short yearBuilt;
        private string numberOfPassengers;
        protected double _maxSpeed;
        protected double currentSpeed;

        //automatic property
        public string ModelName { get; set; }
        //property
        public double MaxSpeed
        {
            get { return _maxSpeed; }
            set { _maxSpeed = value; }
        }

        //methods - operations
        public virtual void Accelerate()
        {
            Console.WriteLine("Vehicle acceleration");
            if (currentSpeed < _maxSpeed)
            {
                currentSpeed += 1.0;
            }
        }
        public virtual void Accelerate(double accelerationFactor)
        {
            Console.WriteLine("Vehicle acceleration");
            if (currentSpeed < _maxSpeed)
            {
                currentSpeed += accelerationFactor;
            }
        }
        public void Brake()
        {
            if (currentSpeed > 0)
            {
                currentSpeed -= 1.0;
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{ModelName}: current speed: {currentSpeed}");
         }

    }