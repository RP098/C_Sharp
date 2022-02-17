using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Kolecje_I_typy_generyczne
{
    class Engine:IComparer<Engine>
    {
        DateTimeOffset DateTimeOffset = new DateTimeOffset(DateTime.Now);
           
        public int power_hp { get; set; }
        public int torque { get; set; }
        public double efficiency { get; set; }
        public bool engine_on_of
        {
            get; set;
        }
        public Engine()
        {
            long seed = DateTimeOffset.ToUnixTimeSeconds();
      
            Random random = new Random((int)Math.Abs(seed)*DateTime.Now.Millisecond);
            power_hp = random.Next(80,160);
            torque = random.Next(170, 250); ;
            efficiency = random.Next(35, 40); ;
            engine_on_of = false;
        }
        public override string ToString()
        {
            return $"PowerHP = {this.power_hp} Torque = {this.torque} Efficiency = {this.efficiency} Engine ON? = {engine_on_of}";
        }

        public int Compare([AllowNull] Engine x, [AllowNull] Engine y)
        {
            if (x.power_hp > y.power_hp)
                return 1;
            else if (x.power_hp == y.power_hp)
                return 0;
            else
                return -1;
        }
    }
}
