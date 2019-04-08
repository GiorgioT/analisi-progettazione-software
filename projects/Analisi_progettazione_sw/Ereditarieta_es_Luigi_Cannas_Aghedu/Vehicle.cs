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

      
        public int NumberOfPassengers { get; set; }

        public int YearBuild { get; set; }

        public void SetNumberOfPassenger()
        {
            this.numberOfPassengers = NumberOfPassengers;
        }

        public void SetYearBuild()
        {
            this.yearBuild = YearBuild;
        }

        public void SetMaxSpeed(double maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }

        public string ModelName { get; set; }

        public virtual void Accellerate()
        {
            if (currentSpeed < maxSpeed)
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
            Console.WriteLine($"Model: {ModelName}, numero passeggeri: {NumberOfPassengers}, Anno di fabbrica: {YearBuild}, current speed: {currentSpeed}, velocità massima: {maxSpeed} ");
        }
    }
}
