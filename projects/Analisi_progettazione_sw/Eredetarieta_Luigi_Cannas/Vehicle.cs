﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Eredetarieta_Luigi_Cannas
{
    class Vehicle
    {
        protected int _maxSpeed=0;
        protected int _currentSpeed=150;
        private int numberOfPassenger;
        private int yearBuild;

        public int MaxSpeed {get; set;}
        public string  ModelName {get; set;}

        public virtual void Accellerate(int _maxSpeed, int _currentSpeed)
            {

            if (_currentSpeed<=_maxSpeed)
            {
                _currentSpeed += 1;

            }
            }

        public void Brake(int _currentSpeed)
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
