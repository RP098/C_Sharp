using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stos_kolejka;

namespace drzewo
{
    class drzewo : IAiSD
    {
        public Wezel korzen;
        public int glebokosc;
        public int lenght;
        public drzewo(int wartosc)
        {
            this.korzen = new Wezel(wartosc);
            this.korzen.wartosc = wartosc;
            this.glebokosc = 0;
            this.lenght = 1;

        }

        public int Lenght => throw new NotImplementedException();

        public int Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(int wartosc)
        {
            Wezel rodzic = znajdzRodzica(wartosc);
            Wezel wezel = new Wezel(wartosc);
            if (rodzic == null)
            {
                korzen = wezel;
            }
            else if (wartosc%2==1)//to samo korzen.wartosc<rodzic.wartosc
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
            List<int> droga = new List<int>();
            int tmp = numer;
            while (tmp > 0)
            {
                if (tmp % 2 == 0)
                      tmp = (tmp / 2) - 1;
                  else
                      tmp = tmp / 2;
              
                
                droga.Add(tmp);
            }
            var rodzic = this.korzen;
            droga.Reverse();
            for (int i = 1; i < droga.Count; i++)
            {
                rodzic= droga[i] % 2 == 1 ?  rodzic.lewa :  rodzic.prawa;
            }
            return rodzic;




        }
        public List<string> PreOrder(Wezel korzen,List<string> elementy)
        {
            
            
            if (korzen != null)
            {
                elementy.Add(Convert.ToString(korzen.wartosc));
                PreOrder(korzen.lewa,elementy);
                PreOrder(korzen.prawa,elementy);
            }


            return elementy;
            
        }

        public List<string> InOrder(Wezel korzen, List<string> elementy)
        {


            if (korzen != null)
            {
        
                InOrder(korzen.lewa, elementy);
                elementy.Add(Convert.ToString(korzen.wartosc));
                InOrder(korzen.prawa, elementy);
            }


            return elementy;

        }
        public List<string> PostOrder(Wezel korzen, List<string> elementy)
        {


            if (korzen != null)
            {
                PostOrder(korzen.lewa, elementy);
                PostOrder(korzen.prawa, elementy);
                elementy.Add(Convert.ToString(korzen.wartosc));
            }


            return elementy;

        }

    }
}



