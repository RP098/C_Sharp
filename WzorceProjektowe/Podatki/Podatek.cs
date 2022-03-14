using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podatki
{
    public delegate decimal DelegatpodatekDochodowy(IPodatekDochodowy podatek,decimal kwota);
    public class Podatek
    {
        public decimal PodatekDochodowy(IPodatekDochodowy podatek,decimal kwota)
        {
            return podatek.podatekDochodowyOblicz(kwota);
        }


    }
}
