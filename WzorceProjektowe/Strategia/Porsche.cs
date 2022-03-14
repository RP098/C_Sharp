using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategia
{
    class Porsche : IStrategyCar
    {
        int MaxSpeed = 280;

     

       public int MaxSpeedCar()
        {
            return MaxSpeed;
        }

        public int MinSpeedCar()
        {
            return 5;
        }
    }
}
