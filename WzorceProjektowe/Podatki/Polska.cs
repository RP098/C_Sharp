using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podatki
{
    public class Polska : IPodatekDochodowy
    {
        public decimal podatekDochodowyOblicz(decimal Kwota) => Kwota * 0.20M;
    }
}
