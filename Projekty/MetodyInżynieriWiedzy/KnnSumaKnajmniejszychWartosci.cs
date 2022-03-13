using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodyInżynieriWiedzy
{
    public partial class KnnSumaKnajmniejszychWartosci : Form
    {
        public KnnSumaKnajmniejszychWartosci()
        {
            InitializeComponent();
        }

        private void KnnSumaKnajmniejszychWartosci_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonKlasyfikuj_Click(object sender, EventArgs e)
        {
        }
        int jakaMetryka()
        {

            if (euklidesowa.Checked)
                return 2;
            if (minkowskiego.Checked)
                return Convert.ToInt32(parametrM.Text.Trim());
            if (logarytmiczna.Checked)
                return -2;
            if (manhatan.Checked)
                return 1;

            if (czybyszewa.Checked)
                return -1;


            return 1;





        }
        bool TakData()
        {
            if (dataTak.Checked)
                return true;
            else
                return false;


        }
        bool TakObiekt()
        {
            if (obiektTak.Checked)
                return true;
            else
                return false;


        }
        string[,] Zwrocobiekt(NormalizujprzedKonfiguracja normalizujprzed, int szerokosc, long dlugosc)
        {

            string[,] Zwrocobiekt = new string[1, szerokosc];
            for (int i = 0; i < szerokosc; i++)
                Zwrocobiekt[0, i] = normalizujprzed.wartosciPoNormalizacji[dlugosc - 1, i];
            return Zwrocobiekt;
        }

        private void buttonKlasyfikuj_Click_1(object sender, EventArgs e)
        {

           try
           {

                var nazwaPliku = textBox2.Text.Trim();
                var nazwaKonfiguracyjnego = konfiguracyjny.Text.Trim();
                norm2 norm = new norm2();
                string[,] obiektTab = new string[1, obiekt.Text.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).Length];

                norm.nazwaKonfiguracyjny = nazwaKonfiguracyjnego.ToString();
                norm.sprawdzCzyIstnieje(norm);
                if (norm.czyIstnieje == false)
                {
                    MessageBox.Show(norm.blad);
                    Exception exception = new Exception();
                    throw exception;
                }
                norm.tablicaDanych = norm.pobierzDane(norm);
                char separator1 = string.IsNullOrEmpty(norm.tablicaDanych[3]) ? ' ' : Convert.ToChar(norm.tablicaDanych[3].Trim());
                WczytajPlik wczytaj = new WczytajPlik(nazwaPliku, separator1);
                wczytaj.dlugosc = Convert.ToInt32(norm.tablicaDanych[1]);
                wczytaj.szerokosc = Convert.ToInt32(norm.tablicaDanych[0]);
                wczytaj.numerKolumnyWartosciDecyzyjnej = Convert.ToInt32(norm.tablicaDanych[2]);
                wczytaj.sprawdzCzyIstnieje(wczytaj);
                if (wczytaj.czyIstnieje == false)
                {
                    MessageBox.Show(wczytaj.blad);
                    Exception exception = new Exception();
                    throw exception;
                }
                wczytaj.tablica = wczytaj.pobierzDane(wczytaj);

            
                string[,] wzoroweWartosci;
                if (!TakData())
                {
                    norm = norm.DzielNaKolumny(wczytaj, norm);
                    if (norm.czyZlaSzerokosc == true)
                    {
                        MessageBox.Show("Zła szerokość numer kolumny błędu" + norm.numerkolumny + "\n numer wiersza" + norm.numerwiersza);
                        Exception exception = new Exception();
                        throw exception;
                    }
                    var pom2 = norm.tablicaDanych[norm.tablicaDanych.Length - 2].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    if (Convert.ToInt32(pom2[0]) == 1)
                    {
                        norm = norm.usunKolumny(wczytaj, norm);
                        wczytaj.szerokosc = norm.szerokosc;

                    }
                    pom2 = norm.tablicaDanych[norm.tablicaDanych.Length - 1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    norm2.zakresX = Convert.ToInt32(pom2[0]);
                    norm2.zakresY = Convert.ToInt32(pom2[1]);

                    norm = norm.normalizuj(wczytaj, norm);
                    wzoroweWartosci = norm.tablicaDonormalizacji;
                }
                else
                {
                    wczytaj.szerokosc = Convert.ToInt32(norm.tablicaDanych[0]);
                    var pom1 = norm.tablicaDanych[norm.tablicaDanych.Length - 2].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    if (Convert.ToInt32(pom1[0]) == 1)
                        wczytaj.szerokosc -= pom1.Length - 1; //czy podczas normalizacji coś usunieto
                                                              //   wczytaj.numerKolumnyWartosciDecyzyjnej = Convert.ToInt32(decyzyjna.Text.Trim()); przy Knn potrzebne
                    wczytaj.separator = Convert.ToChar(separator.Text.Trim());
                    wczytaj.numerKolumnyWartosciDecyzyjnej = Convert.ToInt32(decyzyjna.Text.Trim());

                    norm = norm.DzielNaKolumny(wczytaj, norm);
                    if (norm.czyZlaSzerokosc == true)
                    {
                        MessageBox.Show("Zła szerokość numer kolumny błędu" + norm.numerkolumny + "\n numer wiersza" + norm.numerwiersza);
                        Exception exception = new Exception();
                        throw exception;
                    }

                    wzoroweWartosci = norm.tablicaDonormalizacji;

                }




                var pom = obiekt.Text.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < pom.Length; i++)
                {
                    obiektTab[0, i] = pom[i];
                }

                if (!TakObiekt())
                {
                   // wczytaj.numerKolumnyWartosciDecyzyjnej = Convert.ToInt32(norm.tablicaDanych[2]);
                    norm.tablicaDonormalizacji = obiektTab;
                    wczytaj.dlugosc = 1;
                    wczytaj.szerokosc = Convert.ToInt32(norm.tablicaDanych[0]);
                    var pom3 = norm.tablicaDanych[norm.tablicaDanych.Length - 2].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    norm.tablicaDanych = norm.pobierzDane(norm);

                    if (Convert.ToInt32(pom3[0]) == 1)
                    {
                        norm = norm.usunKolumny(wczytaj, norm);
                        wczytaj.szerokosc = norm.szerokosc;

                    }
                    var pom4 = norm.tablicaDanych[norm.tablicaDanych.Length - 1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    norm2.zakresX = Convert.ToInt32(pom4[0]);
                    norm2.zakresY = Convert.ToInt32(pom4[1]);

                    norm = norm.normalizuj(wczytaj, norm);
                    obiektTab = norm.tablicaDonormalizacji;

                }
            if (!TakData())
            {
                var kolumnyDoUsuniecia = norm.tablicaDanych[norm.tablicaDanych.Length - 2].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                int kolumnadecyzyjna = Convert.ToInt32(norm.tablicaDanych[2]);
                for (int i = 1; i < kolumnyDoUsuniecia.Length; i++)
                {
                    if (Convert.ToInt32(kolumnyDoUsuniecia[i]) < wczytaj.numerKolumnyWartosciDecyzyjnej)
                        kolumnadecyzyjna--;

                }
                wczytaj.numerKolumnyWartosciDecyzyjnej = kolumnadecyzyjna - 1;
            }
            else
            {
                wczytaj.numerKolumnyWartosciDecyzyjnej = Convert.ToInt32(decyzyjna.Text.Trim())-1;
            }
                wczytaj.dlugosc = Convert.ToInt32(norm.tablicaDanych[1]);
                KNN.numerKolumnyWartosciDecyzyjnej = wczytaj.numerKolumnyWartosciDecyzyjnej;
                KNN.szerokosc = wczytaj.szerokosc;
                KNN.dlugosc = Convert.ToInt32(wczytaj.dlugosc);
                int metryka = jakaMetryka();
                KNN kHH = new KNN();
                int kCzydobre = kHH.JakieKsprawdzanieSumNajmniejszych(wzoroweWartosci, wczytaj.dlugosc, wczytaj.numerKolumnyWartosciDecyzyjnej);
                if (!(kCzydobre >= kHH.parametrK))
                {
                    MessageBox.Show("K jest z poza zakresu");
                    Exception exception = new Exception();
                    throw exception;
                }

                string[] obiekt2 = new string[wczytaj.szerokosc];
                for (int i = 0; i < wczytaj.szerokosc; i++)
                {
                    obiekt2[i] = obiektTab[0, i];
                }

                string decyzja = kHH.KlasyfikatorMetodaDruga(Convert.ToInt32(textBox1.Text.Trim()), metryka, wzoroweWartosci, obiekt2);
                MessageBox.Show("Skończono Klasyfikowanie Pomyślnie");
                string[,] obiekt1 = new string[1, obiekt.Text.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).Length];
                var o = obiekt.Text.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < o.Length; i++)
                {
                    obiekt1[0, i] = o[i].ToString();

                }
                Decyzja decyzja1 = new Decyzja(obiekt1, decyzja);
                decyzja1.Show();



           }
            catch
          {
               MessageBox.Show("Błąd danych popraw się :-)");
           }
        }

      

        private void dataTak_CheckedChanged(object sender, EventArgs e)
        {
            numerDecyzja.Visible = true;
            decyzyjna.Visible = true;
            separator.Visible = true;
            asda.Visible = true;
        }

        private void dataNie_CheckedChanged_1(object sender, EventArgs e)
        {
            numerDecyzja.Visible = false;
            decyzyjna.Visible = false;
            separator.Visible = false;
            asda.Visible = false;
        }
    }
}

/*
 var nazwaPliku = textBox2.Text.Trim();
                var separatorPliku = separator.Text;
                int numerwartosciDecyzyjnej = Convert.ToInt32(wartoscDecyzyjna.Text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First());
                string NazwaPliku = nazwaPliku.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First();
                char SeparatorPliku = Convert.ToChar(separatorPliku);
                int dlugospliku = Convert.ToInt32(dlugoscPliku.Text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First());
                WczytajPlik wczytaj = new WczytajPlik(nazwaPliku, SeparatorPliku);
                WczytajPlik czyIstnieje = wczytaj.sprawdzCzyIstnieje(wczytaj);

                if (czyIstnieje.czyIstnieje)
                {



                    wczytaj.dlugosc = dlugospliku + 1;
                    wczytaj.tablica = wczytaj.pobierzDane(wczytaj);
                    wczytaj.separator = SeparatorPliku;
                    wczytaj.numerKolumnyWartosciDecyzyjnej = numerwartosciDecyzyjnej - 1;
                    wczytaj.nazwa = nazwaPliku;
                    int szerokosc = wczytaj.tablica[0].Split(new char[] { wczytaj.separator }).Length;
                    wczytaj.tablica[wczytaj.dlugosc - 1] = obiekt.Text.Replace('-', wczytaj.separator) + wczytaj.separator;
                    if (szerokosc != obiekt.Text.Split(new char[] { '-' }).Length + 1)
                    {
                        MessageBox.Show("Obiekt ma złą długość");
                        Exception exception = new Exception();
                        throw exception;
                    }
                    
                    NormalizujprzedKonfiguracja normalizujprzed = new NormalizujprzedKonfiguracja();
                    NormalizujprzedKonfiguracja.zakresX = Convert.ToInt32(zakresX.Text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First());//mini
                    NormalizujprzedKonfiguracja.zakresY = Convert.ToInt32(zakresY.Text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First());//maxi
                    normalizujprzed = normalizujprzed.DzielNaKolumny(wczytaj);
                    normalizujprzed = normalizujprzed.zamienNaDoubla(wczytaj, normalizujprzed);
                    if (normalizujprzed.blad)
                    {
                        MessageBox.Show("Numer kolumny błędu" + normalizujprzed.numerkolumny + "\n numer wiersza" + normalizujprzed.numerwiersza);
                        Exception exception = new Exception();
                        throw exception;
                    }
                    if (normalizujprzed.formatBladBool)
                    {
                        MessageBox.Show(normalizujprzed.formatBlad);
                        Exception exception = new Exception();
                        throw exception;
                    }
                    normalizujprzed = normalizujprzed.wczytajStringi(wczytaj, normalizujprzed);
                    int metryka = jakaMetryka();

                    string[,] obiektZnormalizowany = Zwrocobiekt(normalizujprzed, szerokosc, wczytaj.dlugosc);
                    wczytaj.dlugosc--;
                    KHH kHH = new KHH(Convert.ToInt32(textBox1.Text.Trim()), metryka, normalizujprzed.wartosciPoNormalizacji, obiektZnormalizowany, szerokosc, wczytaj.numerKolumnyWartosciDecyzyjnej);
                    int kCzydobre = kHH.JakieKsprawdzanieSumNajmniejszych(kHH.ZbiorWartosciWzorcowych,wczytaj.dlugosc,wczytaj.numerKolumnyWartosciDecyzyjnej);
                    if (!(kCzydobre>kHH.parametrK))
                    {
                        MessageBox.Show("K jest z poza zakresu");
                        Exception exception = new Exception();
                        throw exception;
                    }
                    string decyzja = kHH.KlasyfikatorMetodaDruga(kHH, wczytaj);
                    string[,] obiekt1 = new string[1, obiekt.Text.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).Length];
                    var o = obiekt.Text.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < o.Length; i++)
                    {
                        obiekt1[0, i] = o[i].ToString();

                    }
                    Decyzja decyzja1 = new Decyzja(obiekt1, decyzja);
                    decyzja1.Show();
 */
