using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MetodyInżynieriWiedzy
{
    class UsuwanieWybranejKolumny
    {
        public UsuwanieWybranejKolumny(int numerKolumny, WczytajPlik wczytaj)
        {

            string[] kolumnaUsunieta = new string[wczytaj.dlugosc];
            for (int i = 0; i < wczytaj.dlugosc; i++)
            {
                bool czyZapis = true;
                var d = wczytaj.tablica[i].Split(new char[] { wczytaj.separator });
                for (int j = 0; j < d.Length; j++)
                {
                    if (j == numerKolumny)
                        continue;
                    if (czyZapis)
                    {
                        kolumnaUsunieta[i] = d[j].ToString();
                        czyZapis = false;
                    }
                    else
                    {
                        kolumnaUsunieta[i] += wczytaj.separator + d[j].ToString();
                    }


                }

            }



            string nazwaNowegoPliku = "ZmianaKolumn_" + numerKolumny + "_" + wczytaj.nazwa;
            FileInfo fi = new FileInfo(wczytaj.nazwa);
            long dlugosc = wczytaj.dlugosc;
            FileStream fs;

            fs = new FileStream(nazwaNowegoPliku, FileMode.Create);
            fs.Close();
            StreamWriter sw = new StreamWriter(nazwaNowegoPliku);
            for (int i = 0; i < dlugosc; i++)
            {
                sw.WriteLine(kolumnaUsunieta[i]);

            }

            sw.Close();




        }
    }
}
