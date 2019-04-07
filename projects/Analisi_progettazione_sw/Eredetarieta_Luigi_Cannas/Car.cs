﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Eredetarieta_Luigi_Cannas
{
    class Car : StreetVehicle
    {
        private bool motoreAcceso;
        protected double livelloCarburante;
        protected double velocitascelta;


        public void Accendi()
        {
            Console.WriteLine("sto accendendo il motore");
            if (livelloCarburante > 0)
            {
                motoreAcceso = true;
                Console.WriteLine("Il motore è acceso");
            }
            else
            {
                motoreAcceso = false;
                Console.WriteLine("Il motore non si accende, hai fatto benzina?!");
            }

        }

        public void Spegni()
        {
            if (motoreAcceso == false) { 
            Console.WriteLine("Il motore è gia'spento");
            _currentSpeed = 0;
            
            }
            else
            {
                BrakeToStop();
                
            }
           
        }


        public Car(double livelloCarburante)
        {
            
       
            this.livelloCarburante = livelloCarburante;

        }

        public virtual void AccellerateTo(double velocitascelta)
        {
            while ((_currentSpeed < velocitascelta) && (livelloCarburante > 0))
            {
                Console.WriteLine("sto accellerando e il livello carburante è: " + livelloCarburante + " la velocità è " + _currentSpeed);
                _currentSpeed += 1;
                livelloCarburante -= 1;

            }

        }


        public virtual void AccellerateMx()
        {
            while ((_currentSpeed < MaxSpeed) && (livelloCarburante > 0))
            {
            Console.WriteLine("sto accellerando e il livello carburante è: " + livelloCarburante + " la velocità è " + _currentSpeed);
            _currentSpeed += 1;
            livelloCarburante -= 1;

            }

        }

        public virtual void BrakeToStop()
        {
            while ((_currentSpeed > 0))
            {
                Console.WriteLine("sto frenando e il livello carburante è: " + livelloCarburante + " la velocità è " + _currentSpeed);
                _currentSpeed -= 1;
                livelloCarburante -= 1;

            }
            motoreAcceso = false;


        }
    }
    
}
