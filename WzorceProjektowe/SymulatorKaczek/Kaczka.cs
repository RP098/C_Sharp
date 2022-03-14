using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymulatorKaczek
{
    public delegate void Kwakanie(IKonkretnaKaczkaGadajaca konkretna);
    public delegate void Fruwanie(IKaczkaKonkretnaLatajaca konkretna);
    public class Kaczka
    {
        public void Kwakanie(IKonkretnaKaczkaGadajaca konkretna)
        {
            konkretna.kwakanie();
        }

        public void Latanie(IKaczkaKonkretnaLatajaca konkretna)
        {
            konkretna.fruwanie();
        }
    }
}
