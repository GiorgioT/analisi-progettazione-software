﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta_es_Luigi_Cannas_Aghedu
{
    class Car : StreetVehicle
    {
        private bool motoreAcceso;
        protected double livelloCarburante;
        protected double velocitascelta;

        public double LivelloCarburante { get; set; }

        public void Accendi()
        {
            Console.WriteLine("sto accendendo il motore");
            if (!motoreAcceso) 
            {
                if(livelloCarburante > 0)
                {
                    motoreAcceso = true;
                    Console.WriteLine("Il motore è acceso");
                }else
                {
                    Console.WriteLine("Il motore non si accende, hai fatto benzina?!");
                }
                
            }
            
        }

        public void Spegni()
        {
            if ((motoreAcceso)&&(currentSpeed>0))
            {
                BrakeToStop();
            }
            else
            {
                Console.WriteLine("Il motore è spento");
                motoreAcceso=false;
            }
        }

        public Car()
        {
            this.livelloCarburante = LivelloCarburante;
        }

        public Car(double livelloCarburante)
        {
            this.livelloCarburante = livelloCarburante;
        }

        public virtual void AccellerateTo(double velocitascelta)
        {
            while ((currentSpeed < velocitascelta) && (livelloCarburante > 0))
            {
                Console.WriteLine("sto accellerando e il livello carburante è: " + livelloCarburante + " la velocità è " + currentSpeed);
                currentSpeed += 1;
                livelloCarburante -= 1;
            }
        }

        public virtual void AccellerateMx()
        {
            while ((currentSpeed < maxSpeed) && (livelloCarburante > 0))
            {
                Console.WriteLine("sto accellerando e il livello carburante è: " + livelloCarburante + " la velocità è " + currentSpeed);
                currentSpeed += 1;
                livelloCarburante -= 1;
            }
        }

        public virtual void BrakeToStop()
        {
            while ((currentSpeed > 0))
            {
                Console.WriteLine("sto frenando e il livello carburante è: " + livelloCarburante + " la velocità è " + currentSpeed);
                currentSpeed -= 1;
                livelloCarburante -= 1;
            }
            motoreAcceso = false;
        }
    }

}

