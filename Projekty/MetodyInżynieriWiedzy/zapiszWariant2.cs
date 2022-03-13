using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MetodyInżynieriWiedzy
{
    class zapiszWariant2 // przenosi kolumne decyzyjna na początek dlatego że decyzja jest najważniejsza
    {
        public bool czyZapisano;
        public string DanePlikKonfiguracyjny;
        public zapiszWariant2(norm2 normalizujprzed, WczytajPlik wczytaj) 
        {

            long szerokosc = wczytaj.tablica[0].Split(new char[] { wczytaj.separator }).Length;
           
            string[] ciagZapis = zamienNaCiag(wczytaj.dlugosc, wczytaj.szerokosc, normalizujprzed.tablicaDonormalizacji,wczytaj.numerKolumnyWartosciDecyzyjnej,wczytaj.separator);
            
            czyZapisano =zapisDoplikuWariant1(wczytaj, ciagZapis);
        }

        string[] zamienNaCiag(long dlugosc,long szerokosc,string [,] wartosciPonormalizacji,int numerKolumnyDecyzyjnej,char separator)
        {
            string[] ciagZapis = new string[dlugosc];
            
            for(int i=0;i<dlugosc;i++)
            {
                ciagZapis[i] = wartosciPonormalizacji[i,numerKolumnyDecyzyjnej];
            }

            for (int i = 0; i < dlugosc; i++)
            {
               
                for (int j = 0; j < szerokosc; j++)
                {
                    
                    if (j == numerKolumnyDecyzyjnej)
                        continue;
                    wartosciPonormalizacji[i,j]=wartosciPonormalizacji[i, j].Replace(',','.');
                  
                        ciagZapis[i] += separator + wartosciPonormalizacji[i, j] ;
                  
                }
                

            }



            return ciagZapis;

        }
        bool zapisDoplikuWariant1(WczytajPlik wczytaj, string[] ciagZapis)
        {

            string nazwaNowegoPliku = "Wariant_2_" + wczytaj.nazwa;

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
