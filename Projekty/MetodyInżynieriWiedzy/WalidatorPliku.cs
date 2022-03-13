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
    public partial class WalidatorPliku : System.Windows.Forms.Form
    {
        public WalidatorPliku()
        {
            InitializeComponent();
        }

        private void WalidatorPliku_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//BUTTON SPRAWDZAJ
        {
            List<string> napotkaneBledy;
            Walidator walidator = new Walidator();
            walidator.nazwa = textBox2.Text.Trim();
            walidator.sprawdzCzyIstnieje(walidator);
            try
            {
                if(!walidator.czyIstnieje)
                {
                    Exception exception = new Exception();
                    MessageBox.Show(walidator.blad);
                    throw exception;
                }
                walidator.tablica=walidator.pobierzDane(walidator);
                char separator = walidator.tablica[3].Length ==0 ? ' ': Convert.ToChar(walidator.tablica[3].Trim());
                walidator.tablica[3] = separator.ToString();
                WczytajPlik wczytaj= new WczytajPlik(textBox1.Text.Trim(),separator);
                wczytaj.sprawdzCzyIstnieje(wczytaj);
                if (!wczytaj.czyIstnieje)
                {
                    Exception exception = new Exception();
                    MessageBox.Show(wczytaj.blad);
                    throw exception;
                }
                wczytaj.dlugosc = Convert.ToInt32(walidator.tablica[1]);
                wczytaj.tablica = wczytaj.pobierzDane(wczytaj);
             
                napotkaneBledy=walidator.waliduj(walidator, wczytaj);
                walidator.zapisDoplikuWariant1(wczytaj.nazwa, napotkaneBledy);
                MessageBox.Show("Walidacja zakonczona można sprawdzić błędy");
        }
          catch
          {
              MessageBox.Show("błąd bliżej nie znany :-)");
          }

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e) //Plik nazwa
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//Walidator nazwa
        {

        }
    }
}
