using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiecNeuronowa
{
    class Krawedz
    {
        public Node start { get; set; }
        public Node koniec { get; set; }
        public double waga{ get; set; }


        public Krawedz(Node start, Node koniec, double waga = 1)
        {
            this.start = start;
            this.koniec = koniec;
            this.waga = waga;

        }
        public override string ToString()
        {
            return $"{this.start} - {this.koniec} {this.waga} ";
        }

        public Node WezDrugi(Node n)
        {
            return n == this.start ? this.koniec : this.start;
        }


    }
}

