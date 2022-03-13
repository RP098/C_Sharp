using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MetodyInżynieriWiedzy
{
    public class WczytajPlik
    {
        public string nazwa;
        public bool czyIstnieje=true;
        public string blad;
        public char separator;
        public string [] tablica;
        public int szerokosc;
        public int numerKolumnyWartosciDecyzyjnej;
        public long dlugosc;
        public WczytajPlik( string nazwa, char separator)
        {
            this.nazwa = nazwa;
            this.separator = separator;

        }

        public WczytajPlik sprawdzCzyIstnieje(WczytajPlik wczytajPlik)
        {
            FileInfo fi;
            try
            {
                 fi = new FileInfo(wczytajPlik.nazwa);
            }
            catch (ArgumentException)
            {
                czyIstnieje = false;
                wczytajPlik.blad = "Zła nazwa pliku";
                return wczytajPlik;
            }
            fi = new FileInfo(wczytajPlik.nazwa);
            if (!fi.Exists)
            {
                czyIstnieje = false;
                wczytajPlik.blad = "Nie ma takiego pliku";
                return wczytajPlik;
            }
            wczytajPlik.blad = "Plik istnieje";
            wczytajPlik.czyIstnieje = true;
            return wczytajPlik; 
        }

        public string [] pobierzDane(WczytajPlik wczytaj)
        {

            StreamReader streamReader = new StreamReader(wczytaj.nazwa);
            FileInfo fi = new FileInfo(wczytaj.nazwa);
            long dlugosc = wczytaj.dlugosc;
            string line;
            tablica = new string [dlugosc+1];
            
            int i = 0;
            while((line =streamReader.ReadLine())!=null & i<=dlugosc )
            {
                tablica[i++]=line;
               
            }
            streamReader.Close();
           
            return tablica;
        }
     


    }
}
/*
  var liczbys = line.Split(new char[] { wczytaj.separator }, StringSplitOptions.RemoveEmptyEntries);
                    String[] tab = new string[liczbys.Length];
                for (int j=0;j<liczbys.Length;j++)
                {
                    tab[j] = liczbys.ToString();
                }
   StreamWriter sw = new StreamWriter(path);
      sw.Write("Ala");
      sw.WriteLine(" ma kota");
      sw.WriteLine("i tak dalej!");
      sw.Close();
 */