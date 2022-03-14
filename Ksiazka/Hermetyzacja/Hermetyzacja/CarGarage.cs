using System;
using System.Collections.Generic;
using System.Text;

namespace Hermetyzacja
{
    class CarGarage
    {
        public  int numberOfCarsInGarage { get; set; }
        public Car MyAuto { get; set ;  }
       

        public CarGarage()
        {
            MyAuto = new Car();
        }

    }
}
