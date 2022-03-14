using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategia
{
    class Car
    {
        public delegate int SpeedDelegate(IStrategyCar strategyCar);
        public int MaxSpeed(IStrategyCar strategy)
        {
            return strategy.MaxSpeedCar();
        }

        public int MinSpeed(IStrategyCar strategy)
        {
            return strategy.MinSpeedCar();
        }
        
    }

}

  

