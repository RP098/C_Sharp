using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymulatorKaczek
{
   public class KaczkaGumowa : IKonkretnaKaczkaGadajaca
    {
        public void kwakanie()
        {
            Console.WriteLine("Kwik kwik kiwk gumowa kwik kwik") ;
        }
    }
}
