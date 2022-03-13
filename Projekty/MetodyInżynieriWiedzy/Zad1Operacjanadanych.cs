using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MetodyInżynieriWiedzy
{
    public partial class Zad1Operacjanadanych : System.Windows.Forms.Form
    {
        public Zad1Operacjanadanych()
        {
            InitializeComponent();
        }

        private void Zad1Operacjanadanych_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
           {
                var nazwaPliku = nazwa.Text.Trim();
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
                char separator = string.IsNullOrEmpty(norm.tablicaDanych[3]) ? ' ' : Convert.ToChar(norm.tablicaDanych[3].Trim());
                WczytajPlik wczytaj = new WczytajPlik(nazwaPliku, separator);
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
                norm = norm.DzielNaKolumny(wczytaj,norm);
                if (norm.czyZlaSzerokosc == true)
                {
                    MessageBox.Show("Zła szerokość numer kolumny błędu" + norm.numerkolumny + "\n numer wiersza" + norm.numerwiersza);
                    Exception exception = new Exception();
                    throw exception;
                }
                var pom = norm.tablicaDanych[norm.tablicaDanych.Length - 2].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (Convert.ToInt32(pom[0]) == 1)
                {
                    norm = norm.usunKolumny(wczytaj, norm);
                    wczytaj.szerokosc = norm.szerokosc;
                    
                }
                pom= norm.tablicaDanych[norm.tablicaDanych.Length - 1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                norm2.zakresX = Convert.ToInt32(pom[0]);
                norm2.zakresY = Convert.ToInt32(pom[1]);

                norm = norm.normalizuj(wczytaj, norm);
                MessageBox.Show("Znormalizowano");
                zapisDoplikuWariant1(wczytaj.nazwa, norm.listaBledow);



                Zad1Zapisz zad1Zapisz = new Zad1Zapisz(wczytaj, norm);
                zad1Zapisz.Show();

            }
            catch
            {
                MessageBox.Show("Popraw błędy");

            }

        }
        public bool zapisDoplikuWariant1(string nazwa, List<string> ciagZapis)
        {
            try
            {
                string nazwaNowegoPliku = "Błędy_w_" + nazwa;

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
            catch
            {
                return false;
            }
        }
        private void nazwa_TextChanged(object sender, EventArgs e)
        {
            

        }
        /*
         * 
          try
          {
               
                var separatorPliku = separator.Text;
                int numerwartosciDecyzyjnej = Convert.ToInt32(wartoscDecyzyjna.Text.Trim().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).First());
                string NazwaPliku = nazwaPliku.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First();
                char SeparatorPliku=Convert.ToChar(separatorPliku);
                int dlugospliku = Convert.ToInt32(dlugoscPliku.Text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First())-1;
                WczytajPlik wczytaj = new WczytajPlik(nazwaPliku, SeparatorPliku);
                WczytajPlik czyIstnieje = wczytaj.sprawdzCzyIstnieje(wczytaj);
                if (czyIstnieje.czyIstnieje)
                {
                 
                    
                   
                    wczytaj.dlugosc = dlugospliku;
                    wczytaj.tablica = wczytaj.pobierzDane(wczytaj);
                    wczytaj.separator = SeparatorPliku;
                    wczytaj.numerKolumnyWartosciDecyzyjnej = numerwartosciDecyzyjnej-1;
                    wczytaj.nazwa = nazwaPliku;

                    NormalizujprzedKonfiguracja normalizujprzed = new NormalizujprzedKonfiguracja();
                    NormalizujprzedKonfiguracja.zakresX = Convert.ToInt32(zakresX.Text.Trim().Split(new char [] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First());//mini
                    NormalizujprzedKonfiguracja.zakresY = Convert.ToInt32(zakresY.Text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First());//maxi
                    normalizujprzed=normalizujprzed.DzielNaKolumny(wczytaj);
                    normalizujprzed = normalizujprzed.zamienNaDoubla(wczytaj, normalizujprzed);
                    if(normalizujprzed.blad)
                    {
                    MessageBox.Show("Numer kolumny błędu"+normalizujprzed.numerkolumny+"\n numer wiersza"+ normalizujprzed.numerwiersza);
                    Exception exception = new Exception();
                    throw exception;
                    }
                    if (normalizujprzed.formatBladBool)
                    {
                        MessageBox.Show(normalizujprzed.formatBlad);
                        Exception exception = new Exception();
                        throw exception;
                    }
                    normalizujprzed= normalizujprzed.wczytajStringi(wczytaj, normalizujprzed);
                    MessageBox.Show("Znormalizowano");

                    //bool czyzapisano = wczytaj.zapisDoplikuWariant1(wczytaj);

                    Zad1Zapisz zad1Zapisz = new Zad1Zapisz(wczytaj,normalizujprzed);
                    this.Close();
                    zad1Zapisz.Show();
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
         * 
         */
        private void separator_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void wartoscDecyzyjna_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zakresX_TextChanged(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
