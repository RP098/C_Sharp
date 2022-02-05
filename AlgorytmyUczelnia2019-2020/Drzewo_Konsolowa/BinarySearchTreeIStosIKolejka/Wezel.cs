using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stos_kolejka;
namespace drzewo
{
    class Wezel
    {
        public Wezel rodzic;
        public int wartosc;
        public Wezel lewa;
        public Wezel prawa;
        public Wezel(int wartosc)
        {
            this.wartosc = wartosc;

        }
       
    }
}
