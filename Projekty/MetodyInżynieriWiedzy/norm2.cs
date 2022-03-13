using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MetodyInżynieriWiedzy
{
  public  class norm2
    {

        public string nazwaKonfiguracyjny;
        public bool czyIstnieje;
        public string blad;
        readonly char separator = ',';
        public string[] tablicaDanych;
        public string[,] tablicaDonormalizacji;
        public static int zakresX;
        public static int zakresY;
        public bool czyZlaSzerokosc;
        public int numerkolumny;
        public int numerwiersza;
        public int szerokosc;
        public List<string> listaBledow = new List<string>();



        public norm2 sprawdzCzyIstnieje(norm2 walidator)
        {
            FileInfo fi;
            try
            {
                fi = new FileInfo(walidator.nazwaKonfiguracyjny);
            }
            catch (ArgumentException)
            {
                czyIstnieje = false;
                walidator.blad = "Zła nazwa pliku";
                return walidator;
            }
            fi = new FileInfo(walidator.nazwaKonfiguracyjny);
            if (!fi.Exists)
            {
                czyIstnieje = false;
                walidator.blad = "Nie ma takiego pliku";
                return walidator;
            }
            walidator.blad = "Plik istnieje";
            walidator.czyIstnieje = true;
            return walidator;
        }
        public string[] pobierzDane(norm2 wczytaj)
        {

            StreamReader sreamReader = new StreamReader(wczytaj.nazwaKonfiguracyjny);
            FileInfo fi = new FileInfo(wczytaj.nazwaKonfiguracyjny);
            long dlugosc = Convert.ToInt64(sreamReader.ReadLine()) + 6;
            sreamReader.Close();


            StreamReader streamReader = new StreamReader(wczytaj.nazwaKonfiguracyjny);
            string line;
            tablicaDanych = new string[dlugosc];

            int i = 0;
            while ((line = streamReader.ReadLine()) != null & i < dlugosc)
            {
                tablicaDanych[i++] = line.Trim();
                //int szerokosc = wczytaj.tablica[0].Split(new char[] { wczytaj.separator }).Length;
                if (i == 3)
                    tablicaDanych[i] = tablicaDanych[i] == null ? " " : tablicaDanych[i];
            }
            streamReader.Close();
            return tablicaDanych;
        }
        public norm2 DzielNaKolumny(WczytajPlik wczytaj,norm2 normalizujprzed)
        {
         
            normalizujprzed.tablicaDonormalizacji = new string[wczytaj.dlugosc, wczytaj.szerokosc];
            wczytaj.numerKolumnyWartosciDecyzyjnej--;


            int j = 0;

            for (int i = 0; i < wczytaj.dlugosc; i++)
            {

                var stringi = wczytaj.tablica[i].Split(new char[] { wczytaj.separator });
                if (wczytaj.szerokosc == wczytaj.tablica[i].Split(new char[] { wczytaj.separator }).Length)
                {

                    for (j = 0; j < wczytaj.szerokosc; j++)
                    {
                        normalizujprzed.tablicaDonormalizacji[i, j] = stringi[j];
                        normalizujprzed.tablicaDonormalizacji[i, j] = string.IsNullOrEmpty(normalizujprzed.tablicaDonormalizacji[i, j].Trim()) ? "?" : stringi[j];
                    }
                }
                else
                {
                    normalizujprzed.czyZlaSzerokosc = true;
                    normalizujprzed.numerkolumny = j;
                    normalizujprzed.numerwiersza = i;
                    return normalizujprzed;
                }
            }
            return normalizujprzed;
        }

        public norm2 usunKolumny(WczytajPlik wczytaj, norm2 norm2)
        {
            int dlugosc = norm2.tablicaDanych.Length;
            
            var kolumnyDoUsuniecia = norm2.tablicaDanych[norm2.tablicaDanych.Length - 2].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            norm2.szerokosc= wczytaj.szerokosc - kolumnyDoUsuniecia.Length + 1 ;// po returnie przypisac nową szerokość do wczytaj.szerokosc
            string[] nowaTablicaDanych = new string[norm2.tablicaDanych.Length - kolumnyDoUsuniecia.Length + 1];
            nowaTablicaDanych[0] = norm2.tablicaDanych[0];
            nowaTablicaDanych[1] = norm2.tablicaDanych[1];
            nowaTablicaDanych[2] = norm2.tablicaDanych[2];
            nowaTablicaDanych[3] = norm2.tablicaDanych[3];
            nowaTablicaDanych[nowaTablicaDanych.Length - 2] = norm2.tablicaDanych[norm2.tablicaDanych.Length - 2];
            nowaTablicaDanych[nowaTablicaDanych.Length - 1] = norm2.tablicaDanych[norm2.tablicaDanych.Length - 1];
            int kolumnadecyzyjna = wczytaj.numerKolumnyWartosciDecyzyjnej;
            for(int i=1;i<kolumnyDoUsuniecia.Length;i++)
            {
                if (Convert.ToInt32(kolumnyDoUsuniecia[i]) < wczytaj.numerKolumnyWartosciDecyzyjnej)
                    kolumnadecyzyjna--;

            }
            wczytaj.numerKolumnyWartosciDecyzyjnej = kolumnadecyzyjna;

            string[,] nowa = new string[wczytaj.dlugosc, norm2.szerokosc];
            for (int j=0;j<wczytaj.dlugosc;j++)
            {
                int e = 0;
                for (int i=0;i<wczytaj.szerokosc;i++)
                {
                    bool czy = false;
                    for (int d = 1; d < kolumnyDoUsuniecia.Length; d++)
                    {
                        if (i == Convert.ToInt32(kolumnyDoUsuniecia[d]))
                            czy=true;
                    }

                    if (czy)
                        continue;
                    nowa[j, e] = norm2.tablicaDonormalizacji[j, i];
                    if(e<nowaTablicaDanych.Length-6)
                        nowaTablicaDanych[e + 4] = norm2.tablicaDanych[i + 4];
                    e++;
                }

            }
           
            norm2.tablicaDanych = nowaTablicaDanych;
            norm2.tablicaDonormalizacji = nowa;
            return norm2; 
        }

        public norm2 normalizuj(WczytajPlik wczytaj, norm2 norm2)
        {
            for (int i=0;i<wczytaj.szerokosc;i++)
            {
                var pom = norm2.tablicaDanych[i + 4].Split(new char[] {',' },StringSplitOptions.RemoveEmptyEntries);
                if (Convert.ToInt32(pom[0])==1)
                {
                    if (Convert.ToInt32(pom[1]) == 0)
                        norm2 = normalizujLiczby(wczytaj, norm2,i);
                    else
                        norm2 = normalizujStringi(wczytaj, norm2,i);
                }
                else
                    continue;

            }




            return norm2;
        }
        public norm2 normalizujLiczby(WczytajPlik wczytaj, norm2 norm,int numerkolumny)
        {
     
            double zasiegZakresu = norm2.zakresY - norm2.zakresX;
        
            string bledyLiczby = "Kolumna " + (numerkolumny + 1) + "\n";
            var pom = norm.tablicaDanych[4 + numerkolumny].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < wczytaj.dlugosc; i++)
            {
                try
                {
                    norm.tablicaDonormalizacji[i, numerkolumny] = norm.tablicaDonormalizacji[i, numerkolumny].Replace('.', ',');
                    double liczba =Convert.ToDouble(norm.tablicaDonormalizacji[i, numerkolumny]);
                    if (liczba <Convert.ToDouble(pom[2])|| liczba > Convert.ToDouble(pom[3]))
                    {
                        norm.tablicaDonormalizacji[i, numerkolumny] = norm2.zakresX.ToString();
                        bledyLiczby += "błąd zakresu " + "numer kolumny " + (numerkolumny + 1) + "numer wiersza " + (i + 1) + "\n";
                    }
                    else
                    {
                        double min = Convert.ToDouble(pom[2]);
                        double max = Convert.ToDouble(pom[3]);
                        double zakres = max -min;
                        
                        double odleglosc = Convert.ToDouble(tablicaDonormalizacji[i, numerkolumny]) - min;
                        double wartosc = zakres == 0 ? 0 : (odleglosc * zasiegZakresu) / zakres;
                        wartosc += norm2.zakresX;

                        tablicaDonormalizacji[i, numerkolumny] = wartosc.ToString();

                    }
                }
                catch
                {
                    norm.tablicaDonormalizacji[i, numerkolumny] = norm2.zakresX.ToString();
                    bledyLiczby += "błąd typu " + "numer kolumny " + (numerkolumny + 1) + "numer wiersza " + (i + 1) + "\n";
                    continue;
                }

                
                
            }
            norm.listaBledow.Add(bledyLiczby);
            return norm;
        }

        public norm2 normalizujStringi(WczytajPlik wczytaj, norm2 norm, int numerkolumny)
        {
            string bledyStringow = "Kolumna " + (numerkolumny + 1) + "\n";
            Dictionary<string, double> wartosciString = new Dictionary<string, double>();
            var pom = norm.tablicaDanych[4 + numerkolumny].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i=2;i<pom.Length;i++)
            {
                wartosciString[pom[i]] = 0;

            }
            int zakres = norm2.zakresY - norm2.zakresX;
            double liczba = (pom.Length - 3) != 0 ? Convert.ToDouble(zakres) / Convert.ToDouble(pom.Length - 3) : NormalizujprzedKonfiguracja.zakresX;

            double key = norm2.zakresX;

            for (int i = 2; i < pom.Length; i++)
            {
               
                    wartosciString[pom[i]]=key;
                    key += liczba;
                
            }

            for(int i= 0; i<wczytaj.dlugosc;i++)
            {
                if(wartosciString.ContainsKey(norm.tablicaDonormalizacji[i,numerkolumny]))
                {
                    norm.tablicaDonormalizacji[i, numerkolumny] = wartosciString[norm.tablicaDonormalizacji[i, numerkolumny]].ToString();

                }
                else
                {
                    norm.tablicaDonormalizacji[i, numerkolumny] = norm2.zakresX.ToString();
                    bledyStringow += "bląd  nie znana wartość lub brak wartości " + " numer kolumny " + (numerkolumny + 1) + "numer wiersza" + (i + 1) + "\n";
                }

            }
            norm.listaBledow.Add(bledyStringow);



            return norm;
        }

    }
}
