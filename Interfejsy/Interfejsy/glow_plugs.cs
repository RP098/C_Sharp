using System;
using System.Collections.Generic;
using System.Text;

namespace Interfejsy
{
    class glow_plugs:IComparable
    {
        public float temperature { get; set; }
        public readonly float Max_temperature;
        public string mark { get; set; }
        public glow_plugs():this(20,1000,"unnamed")
        {

        }
        public glow_plugs(float temperature,float Max_temperature, string mark)
        {
            this.temperature = temperature;
            this.Max_temperature = Max_temperature;
            this.mark = mark;
        }

        public int CompareTo(object obj)
        {
        
            Exception exception = new Exception();
            glow_plugs glow_plugs = obj as glow_plugs;
            if (glow_plugs == null)
                throw exception;
            if (glow_plugs.Max_temperature > this.Max_temperature)
                return 1;
            else if (glow_plugs.Max_temperature< this.Max_temperature)
                return -1;
            else
                return 0;
    
        }
    }
}
