using System;
using System.Collections.Generic;
using System.Text;


namespace Eredetarieta_Luigi_Cannas
{
    class Vehicle
    {
        protected double _maxSpeed;
        protected double _currentSpeed;
        private int numberOfPassengers;
        private int yearBuild;

        public int MaxSpeed { get; set; }

        public double CurrentSpeed{ get; set; }



        public string  ModelName {get; set;}

        public virtual void Accellerate()
            {
            Console.WriteLine("Stiamo accellerando");
            if (_currentSpeed<MaxSpeed)
            {
                _currentSpeed += 1;

            }
            }

        public void Brake()
        {
            Console.WriteLine("Stiamo frenando");
            if (_currentSpeed > 0)
            {
                _currentSpeed -= 1;

            }

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Model: {ModelName}, current speed :{CurrentSpeed} ");
            //Console.WriteLine("Model: {0} : current speed :{1} ", ModelName, _currentSpeed);
        }

    }


    






}
