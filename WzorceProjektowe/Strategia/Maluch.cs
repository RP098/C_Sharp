using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategia
{
    class Maluch:IStrategyCar
    {

        int MaxSpeed  = 100;
        public int MaxSpeedCar()
        {
            return MaxSpeed;
        }

        public int MinSpeedCar()
        {
            return 20;
        }
    }
}
