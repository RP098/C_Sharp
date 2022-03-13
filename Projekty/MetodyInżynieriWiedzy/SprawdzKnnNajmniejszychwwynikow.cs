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
    public partial class SprawdzKnnNajmniejszychwwynikow : Form
    {
        public SprawdzKnnNajmniejszychwwynikow()
        {
            InitializeComponent();
        }

        private void SprawdzKnnNajmniejszychwwynikow_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            KnnDlaBazyProbek kNNDlaPoj = new KnnDlaBazyProbek();
            kNNDlaPoj.Show();



        }
        private void buttonKlasyfikuj_Click(object sender, EventArgs e)
        {
            //try
            //{
                var nazwaPliku = textBox2.Text.Trim();
                var nazwaKonfiguracyjnego = konfiguracyjny.Text.Trim();
                norm2 norm = new norm2();


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

                if (Convert.ToInt32(textBox1.Text) > wczytaj.dlugosc | Convert.ToInt32(textBox1.Text) <= 0)
                {
                    MessageBox.Show("Podane K jest spoza zakresu");
                    Exception exception = new Exception();
                    throw exception;
                }
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
                    wczytaj.numerKolumnyWartosciDecyzyjnej = Convert.ToInt32(decyzyjna.Text.Trim()) - 1;

                    norm = norm.DzielNaKolumny(wczytaj, norm);
                    if (norm.czyZlaSzerokosc == true)
                    {
                        MessageBox.Show("Zła szerokość numer kolumny błędu" + norm.numerkolumny + "\n numer wiersza" + norm.numerwiersza);
                        Exception exception = new Exception();
                        throw exception;
                    }

                    wzoroweWartosci = norm.tablicaDonormalizacji;


                }

                int metryka = jakaMetryka();

                MessageBox.Show(sprawdzSwegoKnn(wczytaj.szerokosc, wczytaj, Convert.ToInt32(textBox1.Text.Trim()), metryka, wzoroweWartosci));
//            }
            //catch
            //{

  //              MessageBox.Show("Coś poszło nie tak :)");
    //        }
            
            }
        private void buttonKlasyfikuj_Click_1(object sender, EventArgs e)
        {
        /*    try
            {
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



                    wczytaj.dlugosc = dlugospliku;
                    wczytaj.tablica = wczytaj.pobierzDane(wczytaj);
                    wczytaj.separator = SeparatorPliku;
                    wczytaj.numerKolumnyWartosciDecyzyjnej = numerwartosciDecyzyjnej - 1;
                    wczytaj.nazwa = nazwaPliku;
                    int szerokosc = wczytaj.tablica[0].Split(new char[] { wczytaj.separator }).Length;
                  
                 
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
                    if (Convert.ToInt32(textBox1.Text) > wczytaj.dlugosc | Convert.ToInt32(textBox1.Text) <= 0)
                    {
                        MessageBox.Show("Podane K jest spoza zakresu");
                        Exception exception = new Exception();
                        throw exception;
                    }
                    normalizujprzed = normalizujprzed.wczytajStringi(wczytaj, normalizujprzed);
                    int metryka = jakaMetryka();

                    MessageBox.Show(sprawdzSwegoKnn(szerokosc, wczytaj, Convert.ToInt32(textBox1.Text.Trim()), metryka, normalizujprzed.wartosciPoNormalizacji)); 
           
                   

               
                    MessageBox.Show("Skończono Testowanie Pomyślnie");
               
                    

                }
                else
                {
                    MessageBox.Show(czyIstnieje.blad);
                }

            }
            catch
            {
                MessageBox.Show("Błąd danych popraw się :-)");
            }


*/
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

        string sprawdzSwegoKnn(int szerokosc, WczytajPlik wczytaj, int k, int metryka, string[,] ZbiorWartosciWzorcowych)//baza próbek wcześniej znormalizowana
        {
            string odpowiedz;
            double dobrze = 0;
            int nieUdalosie = 0;
            wczytaj.dlugosc--;
            for (int i = 0; i < wczytaj.dlugosc + 1; i++)
            {

                string[] obiekt = zwrocObiekt(0, szerokosc, ZbiorWartosciWzorcowych);
                //przesuniecie kolumny decyzyjnej na koniec
                obiekt = przesunNakoniec(obiekt, szerokosc,wczytaj.numerKolumnyWartosciDecyzyjnej);
                ZbiorWartosciWzorcowych = zwrocWszystkoOproczObiektu(szerokosc, wczytaj.dlugosc, wczytaj.numerKolumnyWartosciDecyzyjnej, ZbiorWartosciWzorcowych, 0);
                KNN.numerKolumnyWartosciDecyzyjnej = wczytaj.numerKolumnyWartosciDecyzyjnej;
                KNN.szerokosc = wczytaj.szerokosc;
                KNN.dlugosc = Convert.ToInt32(wczytaj.dlugosc);

                KNN hH = new KNN();
                string[] obiekt1 = new string[wczytaj.szerokosc];
               
                string decyzja = hH.KlasyfikatorMetodaPierwsza(k, metryka, ZbiorWartosciWzorcowych, obiekt);
                obiekt = przesunTamgdzieBylo(obiekt, szerokosc, wczytaj.numerKolumnyWartosciDecyzyjnej);
                if (decyzja.CompareTo(obiekt[ wczytaj.numerKolumnyWartosciDecyzyjnej]) == 0)
                    dobrze++;
                if (decyzja.CompareTo("N") == 0)
                    nieUdalosie++;
               
                ZbiorWartosciWzorcowych = wPiszObiektNakoniec(szerokosc, wczytaj.dlugosc + 1, ZbiorWartosciWzorcowych, obiekt);

            }
            // dobrze /= Convert.ToDouble(wczytaj.dlugosc) * 100;
            odpowiedz = "RAPORT !! \n" + "Udało się sklasyfikować poprawnie " + dobrze + " próbek \n" + "Niesklasyfikowanych było " + nieUdalosie
                + " próbek \n" +
                "Klasyfikator podjął " + (wczytaj.dlugosc + 1 - nieUdalosie) + " razy decyzje czyli " +
                (Convert.ToDouble(wczytaj.dlugosc + 1 - nieUdalosie) / Convert.ToDouble(wczytaj.dlugosc + 1)) * 100 + "% sklasyfikowanych \n" +
               "Na " + (wczytaj.dlugosc + 1 - nieUdalosie) + " podjetych decyzji " + dobrze + " poprawnych co daje wynik " + dobrze / (wczytaj.dlugosc + 1 - nieUdalosie) * 100 + "% \n" + " Wszystkich próbek było " + (wczytaj.dlugosc + 1);

            return odpowiedz;
        }

        string [] przesunNakoniec(string [] obiekt,int szerokosc,int numerKolumnyWartosciDecyzyjnej)
        {
            string[] pom = new  string[szerokosc] ;
            int d = 0;
           
            pom[szerokosc -1] = obiekt[ numerKolumnyWartosciDecyzyjnej];
            for (int i=0;i<szerokosc;i++)
            {
                if (i != numerKolumnyWartosciDecyzyjnej)
                    pom[ d++] = obiekt[ i];
              

            }



            return pom;
        }
        string[] przesunTamgdzieBylo(string[] obiekt, int szerokosc, int numerKolumnyWartosciDecyzyjnej)
        {
            string[] pom = new string[szerokosc];
            int d = 0;
            pom[numerKolumnyWartosciDecyzyjnej] = obiekt[ szerokosc - 1];
            for (int i = 0; i < szerokosc; i++)
            {
                if (i != numerKolumnyWartosciDecyzyjnej)
                    pom[ i] = obiekt[ d++];
                else
                    continue;

            }




            return pom;
        }
        string[,] wPiszObiektNakoniec(int szerokosc, long dlugosc, string[,] zbiorWartosci, string[] obiekt)
        {
            string[,] zbiorWartosciNowy = new string[dlugosc, szerokosc];

            for (int i = 0; i < dlugosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    if (i < dlugosc - 1)
                        zbiorWartosciNowy[i, j] = zbiorWartosci[i, j];
                    else
                        zbiorWartosciNowy[i, j] = obiekt[ j];
                }


            }

            return zbiorWartosciNowy;
        }

        string[] zwrocObiekt(int numer_Wiersza, int szerokosc, string[,] ZbiorWartosci)
        {
            string[] Obiekt = new string[ szerokosc];
            for (int i = 0; i < szerokosc; i++)
                Obiekt[i] = ZbiorWartosci[numer_Wiersza, i];
            return Obiekt;
        }

        string[,] zwrocWszystkoOproczObiektu(int szerokosc, long dlugosc, int numerWierszaObiektu, string[,] zbiorWartosci, int numerwiersza)
        {

            string[,] zbiorWartosciNowy = new string[dlugosc, szerokosc];
            int d = 0;
            for (int i = 0; i < dlugosc + 1; i++)
            {
                if (!(i == numerwiersza))
                {

                    for (int j = 0; j < szerokosc; j++)
                    {

                        zbiorWartosciNowy[d, j] = zbiorWartosci[i, j];

                    }
                    d++;
                }

            }



            return zbiorWartosciNowy;
        }

        bool TakData()
        {
            if (dataTak.Checked)
                return true;
            else
                return false;


        }
        private void parametrM_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelParM_Click(object sender, EventArgs e)
        {

        }

        private void minkowskiego_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void euklidesowa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void czybyszewa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void manhatan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void logarytmiczna_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dlugoscPliku_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void zakresY_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void zakresX_TextChanged(object sender, EventArgs e)
        {

        }

        private void wartoscDecyzyjna_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void separator_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataTak_CheckedChanged(object sender, EventArgs e)
        {
            numerDecyzja.Visible = true;
            decyzyjna.Visible = true;
            separator.Visible = true;
            asda.Visible = true;
        }

        private void dataNie_CheckedChanged(object sender, EventArgs e)
        {
            numerDecyzja.Visible = false;
            decyzyjna.Visible = false;
            separator.Visible = false;
            asda.Visible = false;
        }

      
    }
}
