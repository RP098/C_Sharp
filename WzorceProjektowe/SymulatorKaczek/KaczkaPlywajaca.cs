using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymulatorKaczek
{
   public class KaczkaPlywajaca : IKonkretnaKaczkaGadajaca,IKaczkaKonkretnaLatajaca
    {
        public void fruwanie()
        {
            Console.WriteLine("Ja fruwam Kwa kwa Pływająca kaczka miło mi");
        }

        public void kwakanie()
        {
            Console.WriteLine("Kwak kwak kwa kaczka pływa kwa kwa") ;
        }
    }
}
