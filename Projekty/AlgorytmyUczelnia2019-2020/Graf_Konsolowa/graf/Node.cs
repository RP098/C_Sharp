using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf
{
    class Node
    {

        public int wartosc;


        public Node(int wartosc)
        {
            this.wartosc = wartosc;
        }
        public override string ToString()
        {
            return this.wartosc.ToString();
        }


    }
}
