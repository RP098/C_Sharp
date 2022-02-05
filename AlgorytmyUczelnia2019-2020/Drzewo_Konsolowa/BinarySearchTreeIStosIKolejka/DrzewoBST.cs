using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stos_kolejka;

namespace drzewo
{
    class DrzewoBST :drzewo, IAiSD
    {

        public DrzewoBST(int wartosc) : base(wartosc) { }
        public void Push(int wartosc)
        {
            Wezel rodzic = znajdzRodzica(wartosc);
            Wezel wezel = new Wezel(wartosc);
            if (rodzic == null)
            {
                korzen = wezel;
            }
            else if (wartosc.CompareTo(rodzic.wartosc) < 0)//to samo korzen.wartosc<rodzic.wartosc
            {
                rodzic.lewa = wezel;

            }
            else
            {
                rodzic.prawa = wezel;
            }
            lenght++;
        }
        public Wezel znajdzRodzica(int numer)
        {
            Wezel rodzic = korzen;
            Wezel poczekalniaRodzicow = null;
            while (rodzic != null)
            {
                bool czyIsntniejeWezel = rodzic.wartosc == numer;//sprawdzam czy istnieje wezel 
                if (!czyIsntniejeWezel)
                {
                    poczekalniaRodzicow = rodzic;
                    rodzic = numer.CompareTo(rodzic.wartosc) < 0 ? rodzic.lewa : rodzic.prawa;
                }
                else
                {
                    Console.WriteLine("Wezel istnieje  ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

            }

            rodzic = poczekalniaRodzicow;
            return rodzic;
        }
        
    }
}
