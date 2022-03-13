using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MetodyInżynieriWiedzy
{
    class Walidator
    {
            public string nazwa;
            public bool czyIstnieje = true;
            public string blad;
            readonly char separator = ',';
            public string[] tablica;
          
            public int numerKolumnyWartosciDecyzyjnej;
            public long dlugosc;
            string[][] daneWalidatora;
            string[,] danePliku;
             public List<string> napotkaneBledy; 
            bool bladKrytyczny =false;
            string numerKolumnyBleduKrytycznego;
            string numerWierszaBleduKrytycznego;

        public Walidator sprawdzCzyIstnieje(Walidator walidator)
            {
                FileInfo fi;
                try
                {
                    fi = new FileInfo(walidator.nazwa);
                }
                catch (ArgumentException)
                {
                    czyIstnieje = false;
                    walidator.blad = "Zła nazwa pliku";
                    return walidator;
                }
                fi = new FileInfo(walidator.nazwa);
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
            public string[] pobierzDane(Walidator wczytaj)
            {

                StreamReader sreamReader = new StreamReader(wczytaj.nazwa);
                FileInfo fi = new FileInfo(wczytaj.nazwa);
            long dlugosc = Convert.ToInt64(sreamReader.ReadLine()) + 4; 
            sreamReader.Close();


                StreamReader streamReader = new StreamReader(wczytaj.nazwa);
                string line;
                tablica = new string[dlugosc];

                int i = 0;
                while ((line = streamReader.ReadLine()) != null & i < dlugosc)
                {
                    tablica[i++] = line.Trim();
                int szerokosc = wczytaj.tablica[0].Split(new char[] { wczytaj.separator }).Length;
                if (i==3)
                        tablica[i]=tablica[i] == null ?" ":tablica[i];
                }
                streamReader.Close();
                return tablica;
            }
            

            public List<string> waliduj(Walidator walidator, WczytajPlik wczytaj)
        {
            napotkaneBledy= new List<string>();
            walidator.daneWalidatora=dzielKonfiguracyjny(walidator.tablica) ;
            walidator.danePliku=dzielNakolumnyPlik( wczytaj.tablica, Convert.ToChar(walidator.tablica[3]) ,Convert.ToInt64(walidator.daneWalidatora[0][0]), Convert.ToInt64(walidator.daneWalidatora[1][0]));
            if (this.bladKrytyczny)
            {
                napotkaneBledy.Add("UWAGA BŁĄD KRYTYCZNY UWAGA UWAGA ZA MAŁA SZEROKOSC !!!!!!!!!!!!!!!!!!"+
                    "\n " +
                    "Numer wiersza "+this.numerWierszaBleduKrytycznego);
                return napotkaneBledy;
            }
            
            for (int i=4; i< walidator.tablica.Length;i++)
            {
                if (Convert.ToInt64(walidator.daneWalidatora[i][0])==1)//1 to string
                {
                    napotkaneBledy.Add(sprawdzStringi(walidator,i-4));

                }
                else//0 to liczba
                {
                    napotkaneBledy.Add(sprawdzLiczby(walidator, i - 4));

                }


            }



            return napotkaneBledy;
        }

        string [,] dzielNakolumnyPlik(string [] tablica, char separator, long szerokosc,long dlugosc)
        {
            string[,] podzielone = new string[dlugosc,szerokosc];
            int i = 0;
            int j = 0;
            for ( i = 0; i < dlugosc; i++)
            {

                var stringi = tablica[i].Split(new char[] { separator });
                if (szerokosc == tablica[i].Split(new char[] { separator }).Length)
                {
                    for ( j = 0; j < szerokosc; j++)
                    {

                        podzielone[i, j] =stringi[j];
            
                    }
                }
                else
                {
                    this.bladKrytyczny = true;
                    //this.numerKolumnyBleduKrytycznego = (j+1).ToString();
                    this.numerWierszaBleduKrytycznego = (i + 1).ToString();
                }
            }

            return podzielone;
        }

        string [][] dzielKonfiguracyjny(string[] tablica)
        {
            long dlugosc = tablica.Length;
            string[][] konifguracyjny= new string[dlugosc][];
            char separator = ',';
            int i = 0;
            int j = 0;
            for (i = 0; i < dlugosc; i++)
            {

                var stringi = tablica[i].Split(new char[] { separator },StringSplitOptions.RemoveEmptyEntries); //dla separatora wyjątek
                konifguracyjny[i] = new string[stringi.Length];
                for (j = 0; j < stringi.Length; j++)
                {
                    konifguracyjny[i][j] = stringi[j];
                }
               
            }

            return konifguracyjny;
        }
        string sprawdzStringi( Walidator walidator, int numerkolumny)
        {
            string bledyStringow="Kolumna "+ (numerkolumny + 1) + "\n";

            for(int i=0;i<Convert.ToInt32(walidator.daneWalidatora[1][0]);i++)
            {
                bool bladWystapi = false;
                for(int j =1;j<walidator.daneWalidatora[numerkolumny+4].Length;j++)
                {

                    if (!walidator.danePliku[i, numerkolumny].Contains(walidator.daneWalidatora[4 + numerkolumny][j]))
                        bladWystapi = true;
                    else
                    {
                        bladWystapi = false;
                        break;
                    }


                }
                if(bladWystapi)
                    bledyStringow += "bląd  nie znana wartość lub brak wartości " + " numer kolumny " + (numerkolumny + 1) + "numer wiersza" + (i+1) + "\n";
            }




            return bledyStringow;
        }

        string sprawdzLiczby(Walidator walidator, int numerkolumny)
        {
            string bledyLiczby = "Kolumna " + (numerkolumny + 1) + "\n";
            
            for (int i = 0; i < Convert.ToInt32(walidator.daneWalidatora[1][0]); i++)
            {
                try
                {
                    walidator.danePliku[i, numerkolumny]=walidator.danePliku[i, numerkolumny].Replace('.',',');
                    Convert.ToDouble(walidator.danePliku[i, numerkolumny]);
                }
                catch
                {
                    bledyLiczby += "błąd typu " + "numer kolumny " + (numerkolumny+1) + "numer wiersza " + (i + 1) + "\n";
                    continue;
                }

                if(Convert.ToDouble(walidator.danePliku[i,numerkolumny])<Convert.ToDouble(walidator.daneWalidatora[numerkolumny+4][1]) | Convert.ToDouble(walidator.danePliku[i, numerkolumny]) > Convert.ToDouble(walidator.daneWalidatora[numerkolumny + 4][2]))
                    bledyLiczby += "błąd zakresu " + "numer kolumny " + (numerkolumny + 1) + "numer wiersza " + (i + 1) + "\n";

            }




            return bledyLiczby;
        }
        public bool zapisDoplikuWariant1(string nazwa,List<string> ciagZapis)
        {
            
            string nazwaNowegoPliku = "Walidator"+nazwa;
           
            FileStream fs;

            fs = new FileStream(nazwaNowegoPliku, FileMode.Create);
            fs.Close();
            StreamWriter sw = new StreamWriter(nazwaNowegoPliku);
            for (int i = 0; i < ciagZapis.Count; i++)
            {
                sw.WriteLine(ciagZapis[i]);

            }

            sw.Close();
            return true;
        }
    }

}

