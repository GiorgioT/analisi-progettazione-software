using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ereditarieta
{
    public class Airplane: FlyingVehicle
    {
        public Airplane()
        {
            MaxSpeed = 1000;
        }

        public override void TakeOffPianoPiano()
        {
            throw new NotImplementedException();
        }
    }
}
