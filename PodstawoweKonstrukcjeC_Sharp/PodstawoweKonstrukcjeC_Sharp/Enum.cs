using System;
using System.Collections.Generic;
using System.Text;

namespace PodstawoweKonstrukcjeC_Sharp
{
    class Enum
    {

        enum kolory :int {
            czerwony = 2,
            zielony= 1

        }
        public void  Enums()
        {
            kolory kolory= new kolory();
            
            Console.WriteLine("Kolor czerwony  = {0} kolor zielony = {1} ", (int)kolory.czerwony, (int)kolory.zielony);
            kolory = kolory.zielony;
            Console.WriteLine(kolory);
            Array arrayKolory = kolory.GetValues(kolory.GetType());
            foreach(var d in arrayKolory)
            {
                Console.WriteLine(d);
            }


        }


    }
}
