using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podatki
{
    public class Niemcy : IPodatekDochodowy
    {
        public decimal podatekDochodowyOblicz(decimal Kwota) => Kwota * 0.15M+2;
    }
}
