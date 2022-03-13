using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MetodyInżynieriWiedzy
{
    class zapiszWariant3 
    {
        public bool czyZapisano;
        public string DanePlikKonfiguracyjny;
        public zapiszWariant3(norm2 normalizujprzed, WczytajPlik wczytaj) //poprawić
        {
            long szerokosc = wczytaj.tablica[0].Split(new char[] { wczytaj.separator }).Length;
           
            string[] ciagZapis = zamienNaCiag(wczytaj, normalizujprzed);
           

            czyZapisano = zapisDoplikuWariant1(wczytaj, ciagZapis);


        }


        string [] zamienNaCiag(WczytajPlik wczytaj,norm2 normalizujprzed)
        {
            string[] ciagZapis = new string[wczytaj.dlugosc];

          
            for (int i = 0; i < wczytaj.dlugosc; i++)
            {
                ciagZapis[i] = normalizujprzed.tablicaDonormalizacji[i, wczytaj.numerKolumnyWartosciDecyzyjnej] ;
            }


            for (int i = 0; i < wczytaj.dlugosc; i++)
            {
                int z = 0;
                for (int j = 0; j < wczytaj.szerokosc; j++)
                {
                    var d=normalizujprzed.tablicaDanych[4 + j].Split(new char[] {',' },StringSplitOptions.RemoveEmptyEntries);
                    if(Convert.ToInt32(d[1])==0 & j!=wczytaj.numerKolumnyWartosciDecyzyjnej)
                        ciagZapis[i] += "|" + normalizujprzed.tablicaDonormalizacji[i, j].ToString();
                   
                    

                }


            }
            for (int i = 0; i < wczytaj.dlugosc; i++)
            {
                int z = 0;
                for (int j = 0; j < wczytaj.szerokosc; j++)
                {
                    var d = normalizujprzed.tablicaDanych[4 + j].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    if (Convert.ToInt32(d[1]) == 1 & j != wczytaj.numerKolumnyWartosciDecyzyjnej)
                        ciagZapis[i] += "|" + normalizujprzed.tablicaDonormalizacji[i, j].ToString();



                }


            }




            return ciagZapis;


        }
        bool zapisDoplikuWariant1(WczytajPlik wczytaj, string[] ciagZapis)
        {

            string nazwaNowegoPliku = "Wariant_3_"+wczytaj.nazwa;

            long dlugosc = wczytaj.dlugosc;
            FileStream fs;

            fs = new FileStream(nazwaNowegoPliku, FileMode.Create);
            fs.Close();
            StreamWriter sw = new StreamWriter(nazwaNowegoPliku);
            for (int i = 0; i < dlugosc; i++)
            {
                sw.WriteLine(ciagZapis[i]);

            }

            sw.Close();
            return true;
        }
    }
}
