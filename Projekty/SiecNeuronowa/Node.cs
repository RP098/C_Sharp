using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiecNeuronowa
{
    class Node
    {

        public double wartosc;


        public Node(double wartosc)
        {
            this.wartosc = wartosc;
        }
        public override string ToString()
        {
            return this.wartosc.ToString();
        }


    }
}
