using System;
using System.Collections.Generic;
using System.Text;

namespace Eredetarieta_Luigi_Cannas
{
    abstract class FlyingVehicle : Vehicle
    {
        protected short directionDegree;
        protected double altitude;
        protected int inclinationDegree;
        //public short DirectionDegree { get; set; }
        //public int Altitude { get; set; }

        //public FlyingVehicle()
        //{
        //    this.directionDegree = DirectionDegree;
        //    this.altitude = Altitude;
        //    Console.WriteLine("la rotta è" + directionDegree);
        //}

        ////public FlyingVehicle(short directionDegree, int altitude)
        ////{
        ////    this.directionDegree = directionDegree;
        ////    this.altitude = altitude;

        ////}


        public FlyingVehicle()
        {
            this.directionDegree = 0;
            this.altitude = 0;

        }

        public virtual void TakeOff()
        {
            Console.WriteLine("Scoiattoli e Tardigradi stiamo decollando");
            inclinationDegree = 15;
            while (this._currentSpeed < 200)
            {
                Accellerate();
                altitude += 1;
                
            }


            if (altitude >= 100)
            {
                inclinationDegree = 0;

            }
        }

        public virtual void Land()
        {



            if (altitude > 0)
            {
                 while (altitude!=0)
                 {
                      altitude -= 1;
                      //_currentSpeed -= 1;

                 }

                 if (_currentSpeed > 0)
                 {
                    while (_currentSpeed>0)
                    {
                      Brake();
                    }


                 }
                

            }
            Console.WriteLine("Scoiattoli e Tardigradi siamo atterrati");

        }

    }
}
