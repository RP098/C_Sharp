using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategia
{
    class Ford:IStrategyCar
    {
         int MaxSpeed = 190;
        public int MaxSpeedCar()
        {
            return MaxSpeed;
        }

        public int MinSpeedCar()
        {
            return 10;
        }
    }
}
