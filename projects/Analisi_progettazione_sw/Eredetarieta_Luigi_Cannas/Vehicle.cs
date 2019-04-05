using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Eredetarieta_Luigi_Cannas
{
    class Vehicle
    {
        protected int _maxSpeed;
        protected int _currentSpeed;
        private int numberOfPassenger;
        private int yearBuild;

        public int MaxSpeed {get; set;}

        public string  ModelName {get; set;}

        public virtual void Accellerate()
            {

            if (_currentSpeed<=_maxSpeed)
            {
                _currentSpeed += 1;

            }
            }

        public void Brake()
        {
            if (_currentSpeed > 0)
            {
                _currentSpeed -= 1;

            }

        }

        public void PrintInfo(string ModelName, int _maxSpeed, int _currentSpeed)
        {
            Console.WriteLine($"{ModelName}: current speed :{_currentSpeed} ");
        }

    }


    






}
