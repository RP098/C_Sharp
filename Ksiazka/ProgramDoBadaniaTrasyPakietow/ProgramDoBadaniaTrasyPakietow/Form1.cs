using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ProgramDoBadaniaTrasyPakietow
{
    public partial class oknoGlowne : Form
    {
      
        public oknoGlowne()
        {
            InitializeComponent();
        }

        sledzeniePakietow sledzenie;
        sledzeniePakietow sledzenie1;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void zamknij_Click(object sender, EventArgs e)
        {
            PotwierdzenieZamkniecia potwierdzenie = new PotwierdzenieZamkniecia();
            potwierdzenie.ShowDialog();

            if (potwierdzenie.zamknij) {
                potwierdzenie.Close();
                this.Close();
            }
            else
            {
                potwierdzenie.Close();
            }
          
        }

        private void minimalizuj_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

     void sledzTraseFunkcja(int rozmiarBuforu,int ttl,int czasOczekiwania,string ipPodane)
        {

            wynik.Invoke((Action)delegate
            {
                wynik.Text = "  ";
            });
            try
            {

                byte[] bufor;
                string buforDane = "a";
                for (int i = 0; i < Convert.ToInt32(rozmiarBuforu) - 1; i++)
                {
                    buforDane += "a";

                }
                bufor = Encoding.ASCII.GetBytes(buforDane);
                sledzenie = new sledzeniePakietow(Convert.ToInt32(ttl), Convert.ToInt32(czasOczekiwania), bufor, ipPodane.ToString());
                sledzenie1 = new sledzeniePakietow(64, Convert.ToInt32(czasOczekiwania), bufor, ipPodane.ToString());
                sledzenie1 = sledzenie1.wyslijPing(sledzenie1);
            wynik.Invoke((Action)delegate
            {
                wynik.Text += "Rozpoczynam śledzenie trasy pakietu do " + ipPodane + sledzenie1.odpowiedz + Environment.NewLine;
            });
             
             
                    for (int i = 1; i <= Convert.ToInt32(ttl); i++)
                    {
                        sledzenie.zmienTTL(i);
                        sledzenie = sledzenie.wyslijPing(sledzenie);
                    wynik.Invoke((Action)delegate
                    {
                        wynik.Text += (" TTL " + i + sledzenie.odpowiedz + Environment.NewLine).ToString();
                    });
                  
                  

        
                    if (sledzenie.czyNastapilBlad)
                            throw new Exception();

                        if (sledzenie.IPhosta.CompareTo(sledzenie1.IPhosta) == 0)
                        {
                            break;
                        }
                    }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void sledzTrase_Click(object sender, EventArgs e)
        {
          
            sledzTrase.Enabled = false;
            if (ipPodane.Text.Length < 1)
            {
                MessageBox.Show("Wprowadź dane do okna \"Podaj adres pakietu\"");
                sledzTrase.Enabled = true;
                return;
            }
            if (ttl.Value == 0)
            {
                MessageBox.Show("Maksymalna liczba skoków musi być większa od zera");
                sledzTrase.Enabled = true;
                return;
            }
            if (czasOczekiwania.Value == 0)
            {
                MessageBox.Show("Czas oczekiwania musi być większy od zera");
                  sledzTrase.Enabled = true;
                return;
            }

             try
               {
                 Convert.ToInt32(rozmiarBuforu.Text);
               }
             catch
               {
            MessageBox.Show("Wprowadzono niewłaściwe znaki do Okna \"Wielkość Buforu\"");
            sledzTrase.Enabled = true;
                  return;
               }
            int rozmiarBuforu_ = rozmiarBuforu.SelectedIndex;
            int ttl_ = Convert.ToInt32(ttl.Value);
            int czasOczekiwania_ = Convert.ToInt32(czasOczekiwania.Value);
            string ipPodane_ = ipPodane.Text;

            await Task.Run(() =>
            {
                sledzTraseFunkcja(rozmiarBuforu_, ttl_, czasOczekiwania_, ipPodane_);
            });

            sledzTrase.Enabled = true;

        }

        private void rozmiarBuforu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wyczysc_Click(object sender, EventArgs e)
        {
            
        }

        private void przerwij_Click(object sender, EventArgs e)
        {
        
      
        }

        private void wyczysc_Click_1(object sender, EventArgs e)
        {
            wynik.Text = "";
            ttl.Value = 0;
            czasOczekiwania.Value = 0;
            ipPodane.Text = "";
        }

        private void czasOczekiwania_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
         
        }
    }
}
