using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MetodyInżynieriWiedzy
{
    class zapiszWariant1 // zmienia separator pliku | i liczba ma przecinek nie kropkę czyli zapis z myślą
                        // o polskich znakach

    {
        public bool czyZapisano;
        public string DanePlikKonfiguracyjny;

        public zapiszWariant1(norm2 normalizujprzed, WczytajPlik wczytaj)
        {
           
        
            string[] ciagZapis = zamienNaCiag(wczytaj.dlugosc,wczytaj.szerokosc,normalizujprzed.tablicaDonormalizacji);
     
            czyZapisano = zapisDoplikuWariant1(wczytaj, ciagZapis);

        }

        string [] zamienNaCiag (long dlugosc, long szerokosc,string [,] wartosciPoNormalizacji)
        {
            string[] ciagZapis = new string[dlugosc];
            
            for(int i=0;i<dlugosc;i++)
            {
                string ciag="";
                for(int j=0;j<szerokosc;j++)
                {
                    if (j < szerokosc - 1)
                        ciag += wartosciPoNormalizacji[i, j] + "|";
                    else
                        ciag += wartosciPoNormalizacji[i, j];
                }
                ciagZapis[i] =ciag;

            }


            return ciagZapis;
        }


        
        
        bool zapisDoplikuWariant1(WczytajPlik wczytaj,string [] ciagZapis)
        {
            try
            {
                string nazwaNowegoPliku = "Wariant_1_" + wczytaj.nazwa;

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
            catch
            {
                return false;
            }
        }
    }
}
