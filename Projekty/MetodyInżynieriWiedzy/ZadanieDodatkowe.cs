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
    public partial class ZadanieDodatkowe : Form
    {
        public ZadanieDodatkowe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var nazwaPliku = nazwa.Text.Trim();
                var separatorPliku = separator.Text;
                int numerwartosciDecyzyjnej = Convert.ToInt32(wartoscDecyzyjna.Text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First());
                string NazwaPliku = nazwaPliku.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First();
                char SeparatorPliku = Convert.ToChar(separatorPliku);
                int dlugospliku = Convert.ToInt32(dlugoscPliku.Text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First()) - 1;
                WczytajPlik wczytaj = new WczytajPlik(nazwaPliku, SeparatorPliku);
                WczytajPlik czyIstnieje = wczytaj.sprawdzCzyIstnieje(wczytaj);
                if (czyIstnieje.czyIstnieje)
                {



                    wczytaj.dlugosc = dlugospliku;
                    wczytaj.tablica = wczytaj.pobierzDane(wczytaj);
                    wczytaj.separator = SeparatorPliku;
                    wczytaj.numerKolumnyWartosciDecyzyjnej = numerwartosciDecyzyjnej - 1;
                    wczytaj.nazwa = nazwaPliku;

                    NormalizujprzedKonfiguracja normalizujprzed = new NormalizujprzedKonfiguracja();
                    NormalizujprzedKonfiguracja.zakresX = 0;//mini
                    NormalizujprzedKonfiguracja.zakresY = 1;//maxi
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

                    string nazwaNowegoPliku = nazwaKonf.Text.Trim();

                    long dlugosc = wczytaj.dlugosc;
                    FileStream fs;

                    fs = new FileStream(nazwaNowegoPliku, FileMode.Create);
                    fs.Close();
                    StreamWriter sw = new StreamWriter(nazwaNowegoPliku);
                    for (int i = 0; i < normalizujprzed.KonfiguracyjnyInfo.Length; i++)
                    {
                        sw.WriteLine(normalizujprzed.KonfiguracyjnyInfo[i]);

                    }

                    sw.Close();

                    MessageBox.Show("Stworzono");


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

        }
    }
}
