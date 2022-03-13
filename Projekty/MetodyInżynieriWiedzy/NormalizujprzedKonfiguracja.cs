using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyInżynieriWiedzy
{
   

        public class NormalizujprzedKonfiguracja
        {
        public string[] KonfiguracyjnyInfo;
        public string[,] wartosciDormalizacji;
            public string[,] wartosciPoNormalizacji;
            public bool blad;
            public int numerkolumny;
            public int numerwiersza;
            public string[,] wartosciString;
            public double[,] wartosciNumbery;
            public static int zakresX;
            public static int zakresY;
            public string formatBlad;
            public List<string> wartosciOznaczajaceNulla = new List<string> { "?", " " };
            public bool formatBladBool;
            private int zasiegZnaczychLiczb = 0; //znanych liczb tych wpisanych do tabeli napewno liczby
            private int zasiegZnaczychStringow = 0;
          
            public NormalizujprzedKonfiguracja DzielNaKolumny(WczytajPlik wczytaj)
            {
                NormalizujprzedKonfiguracja normalizujprzed = new NormalizujprzedKonfiguracja();

                int szerokosc = wczytaj.tablica[0].Split(new char[] { wczytaj.separator }).Length;
                normalizujprzed.wartosciPoNormalizacji = new string[wczytaj.dlugosc, szerokosc];// razem z wartością dezyzyjna
                normalizujprzed.wartosciDormalizacji = new string[wczytaj.dlugosc, szerokosc - 1];//pomniejszone o wartosc decyzyjna
                normalizujprzed.KonfiguracyjnyInfo = new string[szerokosc + 4];
            normalizujprzed.KonfiguracyjnyInfo[0] = szerokosc.ToString();
            normalizujprzed.KonfiguracyjnyInfo[1] = (wczytaj.dlugosc+1).ToString();
            normalizujprzed.KonfiguracyjnyInfo[2] = (wczytaj.numerKolumnyWartosciDecyzyjnej+1).ToString();
            normalizujprzed.KonfiguracyjnyInfo[3] = wczytaj.separator.ToString();
            int i = 0;
                int j = 0;

                for (i = 0; i < wczytaj.dlugosc; i++)
                {

                    var stringi = wczytaj.tablica[i].Split(new char[] { wczytaj.separator });
                    if (szerokosc == wczytaj.tablica[i].Split(new char[] { wczytaj.separator }).Length)
                    {
                    int d = 0;
                        for (j = 0; j < szerokosc; j++)
                        {
                            if (j != wczytaj.numerKolumnyWartosciDecyzyjnej)
                            {
                                normalizujprzed.wartosciDormalizacji[i, d] = stringi[d]; //??? w sumie po co ale działa to lepiej narazie ruszać moje nowatorskie rozwiązanie :-)
                                normalizujprzed.wartosciDormalizacji[i, d] = string.IsNullOrEmpty(normalizujprzed.wartosciDormalizacji[i, d].Trim()) ? "?" : stringi[d];
                            d++;
                            }
                            else
                                normalizujprzed.wartosciPoNormalizacji[i, wczytaj.numerKolumnyWartosciDecyzyjnej] = stringi[d];
                        

                        }
                    }
                    else
                    {
                        normalizujprzed.blad = true;
                        normalizujprzed.numerkolumny = j;
                        normalizujprzed.numerwiersza = i;
                        return normalizujprzed;
                    }
                }
                return normalizujprzed;
            }

            public NormalizujprzedKonfiguracja zamienNaDoubla(WczytajPlik wczytaj, NormalizujprzedKonfiguracja normalizujprzed)
            {
                List<string> liczby = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                long szerokosc = wczytaj.tablica[0].Split(new char[] { wczytaj.separator }).Length - 1; //replace wpisanie do doubla
                string[,] liczbyNapewno;
                string[,] liczbyNapewnoOczyszczone;
                liczbyNapewno = sprawdzCzytoliczba(wczytaj, normalizujprzed, szerokosc, liczby);

                liczbyNapewnoOczyszczone = zamienZnakiNiewiadomeNaMinimalnyZakres(NormalizujprzedKonfiguracja.zakresX, wczytaj.dlugosc + 1, zasiegZnaczychLiczb, normalizujprzed.wartosciOznaczajaceNulla, liczbyNapewno);



                normalizujprzed.wartosciNumbery = new double[wczytaj.dlugosc + 1, zasiegZnaczychLiczb];
                int i = 0;
                int j = 0;
                try
                {
                    for (i = 0; i < wczytaj.dlugosc + 1; i++)//zmienic spowrotem na 0
                    {
                        for (j = 0; j < zasiegZnaczychLiczb; j++)
                        {

                            var liczba = liczbyNapewnoOczyszczone[i, j].ToString();
                            liczba = liczba.Replace('.', ',');
                            normalizujprzed.wartosciNumbery[i, j] = Convert.ToDouble(liczba);

                        }

                    }
                }
                catch
                {

                    normalizujprzed.formatBladBool = true;
                    normalizujprzed.formatBlad = "Nieprawidłowy format ciągu wejsciowego znaki zabronione " + "wiersz " + i + "kolumna " + j;
                    return normalizujprzed;
                }
            normalizujprzed.KonfiguracyjnyInfo = liczbyKonfiguracyjnyTworz(normalizujprzed.wartosciNumbery, zasiegZnaczychLiczb, wczytaj.dlugosc, normalizujprzed.KonfiguracyjnyInfo);
            normalizujprzed.wartosciNumbery = znormalizujLiczby(normalizujprzed.wartosciNumbery, zasiegZnaczychLiczb, wczytaj.dlugosc);
                normalizujprzed.wartosciPoNormalizacji = wpiszLiczbyZnormalizowane(normalizujprzed.wartosciNumbery, zasiegZnaczychLiczb, wczytaj.dlugosc, normalizujprzed.wartosciPoNormalizacji);
                return normalizujprzed;
            }
        string[] liczbyKonfiguracyjnyTworz(double[,] wartosciNumbery, int zasiegZnaczychLiczb, long dlugosc, string[] konfiguracja)
        {
            for (int i = 1; i < dlugosc; i++)
            {
                for (int j = 0; j < zasiegZnaczychLiczb; j++)
                {
                    KonfiguracyjnyInfo[Convert.ToInt32(wartosciNumbery[0, j]) + 4] = "0,";
                    double max = znajdzMax(0, j, dlugosc, wartosciNumbery);
                    KonfiguracyjnyInfo[Convert.ToInt32(wartosciNumbery[0, j]) + 4] += znajdzMin(max, j, dlugosc, wartosciNumbery).ToString().Replace(',','.') + ",";
                    KonfiguracyjnyInfo[Convert.ToInt32(wartosciNumbery[0, j]) + 4] += max.ToString().Replace(',','.');
                   
                }


            }


            return konfiguracja;
        }
        string[,] wpiszLiczbyZnormalizowane(double[,] wartosciNumbery, long zasiegZnaczychLiczb, long dlugosc, string[,] wartosciPonormalizacji)
            {

                for (int i = 0; i < zasiegZnaczychLiczb; i++)
                {
                    for (int j = 0; j < dlugosc; j++)
                    {
                        wartosciPoNormalizacji[j, Convert.ToInt32(wartosciNumbery[0, i])] = wartosciNumbery[j + 1, i].ToString();

                    }

                }
                return wartosciPoNormalizacji;
            }
            double[,] znormalizujLiczby(double[,] wartosciNumbery, long zasiegZnaczychLiczb, long dlugosc)
            {
                double min = 0;
                double max = 0;
                double zakres = 0;
                double zasiegZakresu = NormalizujprzedKonfiguracja.zakresY - NormalizujprzedKonfiguracja.zakresX;
                for (int i = 0; i < zasiegZnaczychLiczb; i++)
                {
                    max = znajdzMax(max, i, dlugosc + 1, wartosciNumbery);
                    min = max;
                    min = znajdzMin(min, i, dlugosc + 1, wartosciNumbery);

                    zakres = max - min;
                    for (int j = 1; j < dlugosc + 1; j++)
                    {
                        double odleglosc = wartosciNumbery[j, i] - min;
                        double wartosc = zakres == 0 ? 0 : (odleglosc * zasiegZakresu) / zakres;
                        wartosc += NormalizujprzedKonfiguracja.zakresX;

                        wartosciNumbery[j, i] = wartosc;

                    }
                    max = 0;

                }

                return wartosciNumbery;
            }

            public double znajdzMin(double min, int numerKolumny, long dlugosc, double[,] wartosciNumbery)
            {
                for (int i = 1; i < dlugosc; i++)
                {
                    if (wartosciNumbery[i, numerKolumny] < min)
                        min = wartosciNumbery[i, numerKolumny];


                }
                return min;

            }
           public double znajdzMax(double max, int numerKolumny, long dlugosc, double[,] wartosciNumbery)
            {
                for (int i = 1; i < dlugosc; i++)
                {


                    if (wartosciNumbery[i, numerKolumny] > max)
                        max = wartosciNumbery[i, numerKolumny];
                }
                return max;

            }
            public string[,] sprawdzCzytoliczba(WczytajPlik wczytaj, NormalizujprzedKonfiguracja normalizujprzed, long szerokosc, List<string> liczby)
            {

                string[,] liczbyNapewno = new string[wczytaj.dlugosc + 1, szerokosc];

                for (int i = 0; i < szerokosc; i++)
                {
                    for (int z = 0; z < liczby.Count; z++)
                    {
                        if (normalizujprzed.wartosciDormalizacji[0, i].ToString().Contains(liczby[z].ToString()))
                        {

                            for (int j = 0; j < wczytaj.dlugosc + 1; j++)
                            {
                                if (j == 0)
                                {
                                    liczbyNapewno[0, zasiegZnaczychLiczb] = Convert.ToString(i);//pierwsza wartosc to numer kolumny która zajmuje wartosc zeby ja wpisać pożniej tak samo
                                }
                                else
                                {
                                    liczbyNapewno[j, zasiegZnaczychLiczb] = normalizujprzed.wartosciDormalizacji[j - 1, i].ToString();
                                }
                            }

                            zasiegZnaczychLiczb++;
                            break;

                        }

                    }




                }


                if (zasiegZnaczychLiczb == szerokosc)
                {
                    return liczbyNapewno;

                }
                //sprawdzam czy początek nie ma ??? nuli albo spacji jesli tak to muszę sklasyfikować  czy tam są liczby czy nie
                for (int i = 0; i < szerokosc; i++)
                {
                    for (int z = 0; z < normalizujprzed.wartosciOznaczajaceNulla.Count; z++)
                    {
                        bool czy = normalizujprzed.wartosciDormalizacji[0, i].Contains(normalizujprzed.wartosciOznaczajaceNulla[z].ToString()) ? true : false;
                        if (czy)//sprawdzam czy peirwsza wartosc nie jest pusta jeśli tak to sprawdzam pozostałe i określam typ
                        {
                            if (funkcjaCzytamSaliczby(i, normalizujprzed.wartosciDormalizacji, wczytaj.dlugosc, liczby))
                            {
                                liczbyNapewno[0, zasiegZnaczychLiczb] = i.ToString();
                                for (int d = 1; d < wczytaj.dlugosc + 1; d++)
                                {
                                    liczbyNapewno[d, zasiegZnaczychLiczb] = normalizujprzed.wartosciDormalizacji[d - 1, i];

                                }
                                zasiegZnaczychLiczb++;

                            }


                        }
                    }




                }


                return liczbyNapewno;
            }
            bool funkcjaCzytamSaliczby(int numerKolumny, string[,] wartosc, long dlugosc, List<string> liczby)
            {

                for (int i = 0; i < dlugosc; i++)
                {
                    for (int z = 0; z < liczby.Count; z++)
                    {
                        if (wartosc[i, numerKolumny].Contains(liczby[z]))
                        {
                            return true;
                        }
                    }

                }

                return false;
            }

            string[,] zamienZnakiNiewiadomeNaMinimalnyZakres(int zakresX, long dlugosc, long szerokosc, List<string> znakiOznaczajaceNull, string[,] tablicaLiczb)
            {

                string[,] liczby = new string[dlugosc, szerokosc];

                for (int i = 0; i < dlugosc; i++)
                {
                    for (int j = 0; j < szerokosc; j++)
                    {
                        for (int d = 0; d < znakiOznaczajaceNull.Count; d++)
                        {
                            if (tablicaLiczb[i, j].Contains(znakiOznaczajaceNull[d]))
                            {

                                liczby[i, j] = zakresX.ToString();//zakres.ToString() dac zamiast 0
                                break;
                            }
                            else
                            {
                                liczby[i, j] = tablicaLiczb[i, j];
                                break;
                            }
                        }

                    }
                }
                return liczby;
            }
            //****************************************************************************************************************************************************************
            // ^^^^^^^^^^^^^^^^   ^^^^^^^^^^^^^^^^^^^^^  ^^^^^^^^^^^^^
            // ^                            ^            ^           ^
            // ^                            ^            ^           ^
            // ^^^^^^^^^^^^^^^^             ^            ^^^^^^^^^^^^^
            //                ^             ^            ^^^^
            //                ^             ^            ^   ^^^^^
            // ^^^^^^^^^^^^^^^^             ^            ^        ^^^^  
            public NormalizujprzedKonfiguracja wczytajStringi(WczytajPlik wczytaj, NormalizujprzedKonfiguracja normalizujprzed)
            {

                List<string> stringi = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j","k",
                                                    "l","m","n","o","u","p","r","s","t","w","y","z","q",
                                                    "Q","W","E","R","T","Y","U","I","O","P","A","S","D","F"
                                                    ,"G","H"
                                                     ,"J","K","L","Z","X","C","V","B","N","M","v"};
                long szerokosc = wczytaj.tablica[0].Split(new char[] { wczytaj.separator }).Length - 1; //pomniejszone o kolumne decyzyjna
                string[,] stringiNapewno;
                string[,] stringiNapewnoOczyszczone; //zamienia znaki zapytania spaacje puste miejsca 
                stringiNapewno = sprawdzCzytoStringi(wczytaj, normalizujprzed, szerokosc, stringi);

                stringiNapewnoOczyszczone = zamienZnakiNiewiadomeNaMinimalnyZakres(NormalizujprzedKonfiguracja.zakresX, wczytaj.dlugosc + 1, zasiegZnaczychStringow, normalizujprzed.wartosciOznaczajaceNulla, stringiNapewno);

                wartosciString = new string[wczytaj.dlugosc + 1, normalizujprzed.zasiegZnaczychStringow];
                for (int i = 0; i < wczytaj.dlugosc + 1; i++)
                {
                    for (int j = 0; j < normalizujprzed.zasiegZnaczychStringow; j++)
                    {
                        wartosciString[i, j] = stringiNapewnoOczyszczone[i, j];
                    }
                }
            normalizujprzed.KonfiguracyjnyInfo = stringiKonfiguracyjnyTworz(normalizujprzed.wartosciString, zasiegZnaczychStringow, wczytaj.dlugosc, normalizujprzed.KonfiguracyjnyInfo);
            wartosciString = zamienStringiNaLiczby(normalizujprzed, wczytaj, zasiegZnaczychStringow);

                normalizujprzed.wartosciPoNormalizacji = wpiszStringiZnormalizowane(normalizujprzed.wartosciString, wczytaj.dlugosc, zasiegZnaczychStringow, normalizujprzed.wartosciPoNormalizacji);





                return normalizujprzed;
            }
        string[] stringiKonfiguracyjnyTworz(string[,] wartosciStringi, int zasiegZnaczychStringow, long dlugosc, string[] KonfiguracyjnyInfo)
        {

            for (int i = 1; i < dlugosc; i++)
            {
                for (int j = 0; j < zasiegZnaczychStringow; j++)
                {
                    KonfiguracyjnyInfo[Convert.ToInt32(wartosciStringi[0, j]) + 4] = "1";
                    string[] zbiorStr = zbior(wartosciStringi, j, dlugosc, zasiegZnaczychStringow);
                    for (int k = 0; k < zbiorStr.Length; k++)
                    {
                        if (zbiorStr[k].Contains(NormalizujprzedKonfiguracja.zakresX.ToString()))
                            continue;
                        KonfiguracyjnyInfo[Convert.ToInt32(wartosciStringi[0, j]) + 4] += "," + zbiorStr[k] ;
                    }

                }


            }


            return KonfiguracyjnyInfo;
        }
        public string[,] sprawdzCzytoStringi(WczytajPlik wczytaj, NormalizujprzedKonfiguracja normalizujprzed, long szerokosc, List<string> stringi)
            {

                string[,] stringiNapewno = new string[wczytaj.dlugosc + 1, szerokosc];

                for (int i = 0; i < szerokosc; i++)
                {
                    for (int z = 0; z < stringi.Count; z++)
                    {

                        if (normalizujprzed.wartosciDormalizacji[0, i].ToString().Contains(stringi[z].ToString()))
                        {

                            for (int j = 0; j < wczytaj.dlugosc + 1; j++)
                            {
                                if (j == 0)
                                {
                                    stringiNapewno[0, zasiegZnaczychStringow] = Convert.ToString(i);//pierwsza wartosc to numer kolumny która zajmuje wartosc zeby ja wpisać pożniej tak samo
                                }
                                else
                                {
                                    stringiNapewno[j, zasiegZnaczychStringow] = normalizujprzed.wartosciDormalizacji[j - 1, i].ToString();
                                }
                            }

                            zasiegZnaczychStringow++;
                            break;

                        }

                    }




                }


                if (zasiegZnaczychStringow == szerokosc)
                {
                    return stringiNapewno;

                }
                //sprawdzam czy początek nie ma ??? nuli albo spacji jesli tak to muszę sklasyfikować  czy tam są liczby czy nie
                for (int i = 0; i < szerokosc; i++)
                {
                    for (int z = 0; z < normalizujprzed.wartosciOznaczajaceNulla.Count; z++)
                    {
                        bool czy = normalizujprzed.wartosciDormalizacji[0, i].Contains(normalizujprzed.wartosciOznaczajaceNulla[z].ToString()) ? true : false;
                        if (czy)//sprawdzam czy peirwsza wartosc nie jest pusta jeśli tak to sprawdzam pozostałe i określam typ
                        {
                            if (funkcjaCzytamSaStringi(i, normalizujprzed.wartosciDormalizacji, wczytaj.dlugosc, stringi))
                            {
                                stringiNapewno[0, zasiegZnaczychStringow] = i.ToString();
                                for (int d = 1; d < wczytaj.dlugosc + 1; d++)
                                {
                                    stringiNapewno[d, zasiegZnaczychStringow] = normalizujprzed.wartosciDormalizacji[d - 1, i];

                                }
                                zasiegZnaczychStringow++;

                            }


                        }
                    }




                }


                return stringiNapewno;
            }
            bool funkcjaCzytamSaStringi(int numerKolumny, string[,] wartosc, long dlugosc, List<string> stringi)
            {

                for (int i = 0; i < dlugosc; i++)
                {
                    for (int z = 0; z < stringi.Count; z++)
                    {
                        if (wartosc[i, numerKolumny].Contains(stringi[z]))
                        {
                            return true;
                        }
                    }

                }

                return false;
            }

            string[,] zamienStringiNaLiczby(NormalizujprzedKonfiguracja normalizujprzed, WczytajPlik wczytaj, int szerokosc)
            {
                String[] zbiorString;
                Dictionary<string, int> slownik;
                String[] zbiorStringOdNajrzadziejWystepujacychDonajczesciej;
                String[] zamienioneNaliczby;
                for (int i = 0; i < szerokosc; i++)
                {
                    zbiorString = zbior(normalizujprzed.wartosciString, i, wczytaj.dlugosc, NormalizujprzedKonfiguracja.zakresX);
                    slownik = zwrocSlownik(zbiorString, normalizujprzed.wartosciString, wczytaj.dlugosc, i, NormalizujprzedKonfiguracja.zakresX);
                    zbiorStringOdNajrzadziejWystepujacychDonajczesciej = wykorzystajSlownikDoPseudoSortowania(slownik);

                    zamienioneNaliczby = zamianaNaliczby(i, zbiorStringOdNajrzadziejWystepujacychDonajczesciej, normalizujprzed, wczytaj);
                    for (int j = 1; j < wczytaj.dlugosc + 1; j++)
                    {
                        normalizujprzed.wartosciString[j, i] = zamienioneNaliczby[j - 1];
                    }
                }



                return normalizujprzed.wartosciString;
            }
            string[,] wpiszStringiZnormalizowane(string[,] wartosciStringi, long dlugosc, long zasiegZnaczychStringow, string[,] wartosciPonormalizacji)
            {

                for (int i = 0; i < zasiegZnaczychStringow; i++)
                {
                    for (int j = 0; j < dlugosc; j++)
                    {
                        wartosciPoNormalizacji[j, Convert.ToInt32(wartosciStringi[0, i])] = wartosciStringi[j + 1, i];

                    }

                }
                return wartosciPoNormalizacji;
            }


           public string[] zbior(string[,] tablicaStringi, int numerKolumny, long dlugosc, long zakres)
            {
                HashSet<string> hashZbior = new HashSet<string>();
                for (int i = 1; i < dlugosc + 1; i++)
                {
                    if (tablicaStringi[i, numerKolumny] != zakres.ToString())
                        hashZbior.Add(tablicaStringi[i, numerKolumny]);

                }
                String[] zbior = new string[hashZbior.Count];
                hashZbior.CopyTo(zbior);


                return zbior;
            }
            Dictionary<string, int> zwrocSlownik(string[] zbior, string[,] stringi, long dlugosc, int numerKolumny, long zakres)
            {


                Dictionary<string, int> slownik = new Dictionary<string, int>();
                for (int i = 0; i < zbior.Length; i++)
                    slownik.Add(zbior[i], 0);


                for (int i = 1; i < dlugosc + 1; i++)
                {
                    if (stringi[i, numerKolumny] != zakres.ToString())
                        slownik[stringi[i, numerKolumny]]++;

                }

                return slownik;
            }

            string[] wykorzystajSlownikDoPseudoSortowania(Dictionary<string, int> slownik)
            {


                string[] tablica = new string[slownik.Count];
                int[] tablica2 = new int[slownik.Count];

                int i = 0;
                foreach (var d in slownik.Keys)
                {
                    tablica[i++] = d;

                }
                i = 0;
                foreach (var d in slownik.Values)
                {
                    tablica2[i++] = d;

                }
                Array.Sort(tablica2, tablica);//od najmniejszego do największego


                return tablica;
            }
            string[] zamianaNaliczby(int numerKolumny, string[] zbiorStringOdNajrzadziejWystepujacychDonajczesciej, NormalizujprzedKonfiguracja normalizujprzed, WczytajPlik wczytaj)
            {
            string[] zamienione = new string[wczytaj.dlugosc];
            Dictionary<string, double> tmpSlownik = new Dictionary<string, double>();
            int zakres = NormalizujprzedKonfiguracja.zakresY - NormalizujprzedKonfiguracja.zakresX;
            double liczba = (zbiorStringOdNajrzadziejWystepujacychDonajczesciej.Length - 1) != 0 ? Convert.ToDouble(zakres) / Convert.ToDouble(zbiorStringOdNajrzadziejWystepujacychDonajczesciej.Length - 1) : NormalizujprzedKonfiguracja.zakresX;

            double key = NormalizujprzedKonfiguracja.zakresX;

            for (int i = 0; i < zbiorStringOdNajrzadziejWystepujacychDonajczesciej.Length; i++)
            {

                tmpSlownik.Add(zbiorStringOdNajrzadziejWystepujacychDonajczesciej[i], key);
                key += liczba;

            }

            for (int i = 1; i < wczytaj.dlugosc + 1; i++)
            {
                if (!normalizujprzed.wartosciString[i, numerKolumny].Contains(NormalizujprzedKonfiguracja.zakresX.ToString()))
                    zamienione[i - 1] = tmpSlownik[normalizujprzed.wartosciString[i, numerKolumny]].ToString();
                else
                    zamienione[i - 1] = NormalizujprzedKonfiguracja.zakresX.ToString();
            }

            return zamienione;
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
       int j = 0;
wartosciNumbery = new double[wczytaj.dlugosc+1, szerokosc];
for (int i = 0; i < szerokosc; i++)
{
    for (int z = 0; z < 10; z++)
    {
        if (normalizujprzed.wartosciDormalizacji[0, i].ToString().Contains(liczby[z]))
        {
            int d = 0;
            wartosciNumbery[d, i] = i; //pierwsza wartosc to numer zajmowanej kolumny

            for (d = 1; d < wczytaj.dlugosc; d++)
            {
                wartosciNumbery[d, i] = normalizujprzed.wartosciDormalizacji[d,];
                for (int e = 0; e < normalizujprzed.wartosciOznaczajaceNulla.Count; e++)
                {
                    if (normalizujprzed.wartosciDormalizacji[d, i].ToString().Contains(normalizujprzed.wartosciOznaczajaceNulla[e]))
                    {
                        wartosciNumbery[d,]
                                }

                }
                // wartosciNumbery[d,i] =Convert.ToDouble( normalizujprzed.wartosciDormalizacji[d, i]);

            }
        }
        else
        {



        }


        */
