using System;
using System.Collections.Generic;
using System.Text;

namespace Interfejsy
{
    abstract class Engine:ISwitch, IComparable
    {
        public int power_hp { get; set; }
        public int torque { get; set; }
        public double efficiency { get; set; }
        public bool engine_on_of { get; set; }
        public Engine():this(1,1,10)
        {

        }

        public Engine(int power_hp,int torque,double efficiency)
        {
            this.power_hp = power_hp;
            this.torque = torque;
            this.efficiency = efficiency;
        }

        public abstract bool Switch_ON();
        public abstract bool Switch_OFF();

        public abstract int CompareTo(object obj);
    }
}
