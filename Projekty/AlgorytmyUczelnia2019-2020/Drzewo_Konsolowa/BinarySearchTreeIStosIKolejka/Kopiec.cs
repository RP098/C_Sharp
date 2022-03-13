using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stos_kolejka;
namespace drzewo
{
    class Kopiec 
    {
        
        public int[] kopiecDane;
        public int Lenght ;
        public Kopiec ()
        {
            this.Lenght = 0;
            this.kopiecDane = new int[this.Lenght];
        }
        public void Push(int element)
        {
            this.Lenght++;
            int[] nowyKopiec = this.Przepisz(this.kopiecDane);

            nowyKopiec[this.Lenght - 1] = element;
            sprawdzKopiec(nowyKopiec);
            this.kopiecDane = nowyKopiec;
            

        }
        protected int[] Przepisz(int[] staryKopiec)
        {

            int[] nowa = new int[staryKopiec.Length + 1];
            for (int i = 0; i < staryKopiec.Length; i++)
            {
                nowa[i] = staryKopiec[i];
            }
            return nowa;
        }

        void sprawdzKopiec(int [] nowyKopiec)
        {
            int pomoc;
            int indexRodzica = nowyKopiec.Length - 1;
            int indexDziecka = nowyKopiec.Length - 1;
            while(indexRodzica>0)
            {
                --indexRodzica;
                indexRodzica = indexRodzica / 2;
                if (nowyKopiec[indexDziecka] > nowyKopiec[indexRodzica])
                {
                    pomoc = nowyKopiec[indexDziecka];
                    nowyKopiec[indexDziecka] = nowyKopiec[indexRodzica];
                    nowyKopiec[indexRodzica] = pomoc;
                }
                indexDziecka = indexRodzica;
            }
            
        }
        
        public void pokazKopiec()
        {
            for (int i = 0; i < kopiecDane.Length; i++)
            {
                Console.WriteLine("{0}", kopiecDane[i]);
            }
        }

        public  List<int> sortowaniePrzeKopcowanie()
        {
            
            List<int> nowaListaKopca= new List<int>();
            while (kopiecDane.Length>0) 
            {   
                nowaListaKopca.Add(kopiecDane[0]);
                kopiecDane[0] = kopiecDane[kopiecDane.Length - 1];
                kopiecDane = usunDane(kopiecDane);
                odbudujKopiec(kopiecDane, 0, kopiecDane.Length-1);
                
            }

            return nowaListaKopca;
        }
        
        int [] usunDane(int [] starykopiec)
        {
            Lenght--;
            int[] tablicaNowa = new int[starykopiec.Length-1];
            for(int i=0;i<starykopiec.Length-1;i++)
                tablicaNowa[i] = starykopiec[i];
            return tablicaNowa;
        }
        static void odbudujKopiec(int[] kopiec, int indeksStartowy, int indekKoncowy)
        {
            int korzen = indeksStartowy;

            while (korzen * 2 + 1 < indekKoncowy)
            {
                int dziecko = korzen * 2 + 1;
                int rodzic = korzen;
                if (kopiec[rodzic] < kopiec[dziecko])
                    rodzic = dziecko;
                if (dziecko + 1 <= indekKoncowy && kopiec[rodzic] < kopiec[dziecko + 1])
                    rodzic = dziecko + 1;
                if (rodzic != korzen)
                {
                    int tmp = kopiec[rodzic];
                    kopiec[rodzic] = kopiec[korzen];
                    kopiec[korzen] = tmp;
                    korzen = rodzic;
                }
                else
                    return;
            }
        }

    }
}
