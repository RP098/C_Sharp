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
    public partial class UsunKolumne : Form
    {
        public UsunKolumne()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var nazwaPliku = nazwa.Text.Trim();
                var separatorPliku = separator.Text;
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
                    wczytaj.nazwa = nazwaPliku;
                    UsuwanieWybranejKolumny usuwanie = new UsuwanieWybranejKolumny(Convert.ToInt32(numerKolumny.Text.Trim()),wczytaj);
                   
                    MessageBox.Show("Usunięto"+"nazwa pliku to"+"ZmianaKolumn_" + numerKolumny.Text.Trim() + "_" + wczytaj.nazwa);

                    //bool czyzapisano = wczytaj.zapisDoplikuWariant1(wczytaj);

                  
                }
                else
                {
                    MessageBox.Show(czyIstnieje.blad);
                }

            }
            catch
            {

                MessageBox.Show("Podano błędne dane");

            }


        }
    }
}
