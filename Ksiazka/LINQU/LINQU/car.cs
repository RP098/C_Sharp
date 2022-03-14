using System;
using System.Collections.Generic;
using System.Text;

namespace LINQU
{
    class car
    {
        public int Speed { get; set; }
        public string Mark { get; set; }
        public List<car> cars { get; set; }
        public car():this(1,"unnamed")
        {

        }
        public car(int speed,string mark)
        {
            Speed = speed;
            Mark = mark;
        }
    }
}
