using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stos_kolejka
{
    class kolejka : SD, IAiSD
    {
        public int Pop()
        {
            if (Lenght == 0)
            {

                Console.WriteLine("Nikt nie czeka w Kolejce kolejka jest pusta");
                return 0;

            }
            Lenght--;
            int elementKtoryZostalUsunietyZkolejki = this.PrzepiszKolejke(this.dane);
            return elementKtoryZostalUsunietyZkolejki;

        }
        protected int PrzepiszKolejke(int[] staraKolejka)
        {
            
            int[] nowaKolejka = new int[staraKolejka.Length - 1];
            int elementUsuwanyZKolejki = staraKolejka[staraKolejka.Length - 1];
            int j = 1;
            for (int i = 0; i <= staraKolejka.Length - 2; i++)
            {
                nowaKolejka[i] = staraKolejka[j];
                j++;
            }
            this.dane = nowaKolejka;
            return elementUsuwanyZKolejki;
        }
    }
}
