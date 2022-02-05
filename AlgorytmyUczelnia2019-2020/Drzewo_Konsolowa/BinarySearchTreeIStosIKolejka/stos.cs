using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stos_kolejka
{
    class stos : SD, IAiSD
    {

        public int Pop()
        {
            if (Lenght == 0)
            {

                Console.WriteLine("Na stosie nie ma nikogo nie ma co podpalac");
                return 0;

            }
            Lenght--;
            int elementKtoryZostalUsunietyZeStosu = this.PrzepiszStos(this.dane);
            return elementKtoryZostalUsunietyZeStosu;

        }
        protected int PrzepiszStos(int[] staraStos)
        {
            int elementStosuUsuwany;
            int[] nowyStos = new int[staraStos.Length - 1];
            elementStosuUsuwany = staraStos[staraStos.Length - 1];
            for (int i = 0; i <= staraStos.Length - 2; i++)
            {
                nowyStos[i] = staraStos[i];
            }
            return elementStosuUsuwany;
        }

    }
}
