using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf
{
    class Krawedz
    {
        public Node start;
        public Node koniec;
        public int waga = 1;

        public Krawedz(Node start, Node koniec, int waga = 1)
        {
            this.start = start;
            this.koniec = koniec;
            this.waga = waga;
        }
        public override string ToString()
        {
            return $"{this.start} - {this.koniec} ({this.waga})";
        }

        public Node WezDrugi(Node n)
        {
            return n == this.start ? this.koniec : this.start;
        }


    }
}

