using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiecNeuronowa
{
    public partial class Pytaj : Form
    {
        public Pytaj()
        {
            InitializeComponent();
        }

        private void Pytaj_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PytajButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioOkno.Checked)
                {
                    OknoPytanie();

                }
                else
                {
                    PlikPytanie();



                }
           }
           catch
            {

                MessageBox.Show("Wystąpił Błąd");
           }
        }

        private void PlikPytanie()
        {

            graf graf1 = new graf();
            graf.struktura = struktura.Text.Trim();
            WczytajProbkeAlboWagi wczytaj = new WczytajProbkeAlboWagi();
            graf1.wagiZpliku = wczytaj.pobierzWagi(graf1.LiczbaKrawedzi(graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)), wagi.Text.Trim());
            wczytaj = wczytaj.pobierzProbki(graf1.liczbaNodow(graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)), nazwaProbki.Text.Trim());
            graf1.wartosciWejscia = wczytaj.tablica[0];
            var d = wczytaj.wartosciZadane.First().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            for (int q = 0; q < wczytaj.wartosciZadane.First().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Length; q++)
                graf.wartosciZadaneNaWyjscia.Add(Convert.ToDouble(d[q].Replace('.', ',')));

            var node = graf1.AutomatyczneTworzenieNodow(graf.struktura);
            var node2 = graf1.PrzypiszWartosciDoNodow(graf1.wartosciWejscia, node);
            var kraw = graf1.ZwrocKrawedzie(node2, graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries));
            kraw = graf1.przypisWartosciDoKrawedzi(kraw, graf1.wagiZpliku);

            var kraw1 = graf1.obliczWyjscia(node2, kraw, graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries));

            var ile = Convert.ToInt32(graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Last());
            Odpowiedz.Text += "odp = ";
            for (int p = 0; p < Convert.ToInt32(graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Last()); p++)
            {
                Odpowiedz.Text += Math.Round( node2[node2.Count - ile - p-1].wartosc).ToString()+" ";
                    
            }
           










        }

        private void OknoPytanie()
        {

            graf graf1 = new graf();
            graf.struktura = struktura.Text.Trim();
            WczytajProbkeAlboWagi wczytaj ;
            graf1.wagiZpliku = pobierzWagi(graf1.LiczbaKrawedzi(graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)), wagi.Text.Trim());
            wczytaj = pobierzProbki(graf1.liczbaNodow(graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)), nazwaProbki.Text.Trim());
            graf1.wartosciWejscia = wczytaj.tablica[0];
           
            var node = graf1.AutomatyczneTworzenieNodow(graf.struktura);
            var node2 = graf1.PrzypiszWartosciDoNodow(graf1.wartosciWejscia, node);
            var kraw = graf1.ZwrocKrawedzie(node2, graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries));
            kraw = graf1.przypisWartosciDoKrawedzi(kraw, graf1.wagiZpliku);

            var kraw1 = graf1.obliczWyjscia(node2, kraw, graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries));

            var ile = Convert.ToInt32(graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Last());
            Odpowiedz.Text += "odp = ";
            for (int p = 0; p < Convert.ToInt32(graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Last()); p++)
            {
                Odpowiedz.Text += Math.Round(node2[node2.Count - ile - p-1].wartosc).ToString() + " ";

            }
           

        }


     
        string[] pobierzWagi(int dlugosc, string nazwa)
        {
           
            string[] tablica = new string[dlugosc];
            var line = textBox1.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        
            for(int i =0;i<dlugosc;i++)
                tablica[i] = line[i];

            
    

            return tablica;
        }

         WczytajProbkeAlboWagi pobierzProbki(int dlugosc, string nazwa)
        {
            WczytajProbkeAlboWagi wczytaj = new WczytajProbkeAlboWagi();
            List<string> tablica = new List<string>();
          

            var line= textBox2.Text.Split(new char[] {';' },StringSplitOptions.RemoveEmptyEntries);
           

            for(int i=0;i<line.Length;i++)
            {
                tablica.Add(line[i]);
            }
           



   
            wczytaj.tablica = new string[1][];
            int z = 0;
          
            wczytaj.tablica[0] = new string[dlugosc];
            for (int j = 0; j < dlugosc; j++)
            {
                    wczytaj.tablica[0][j] = tablica[z++];

            }
             
            


            return wczytaj;
        }

        private void radioPlik_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
