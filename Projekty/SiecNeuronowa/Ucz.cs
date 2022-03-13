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
namespace SiecNeuronowa
{
    public partial class Ucz : Form
    {
        List<Krawedz> krawedzs { get; set; } = new List<Krawedz>();
        public Ucz()
        {
            InitializeComponent();
            

            dataGridView1.DataSource = krawedzs;
            dataGridView1.Font = new Font("Arial", 20);
            dataGridView1.RowHeadersWidth = 100;
            
        }

        private void Ucz_Load(object sender, EventArgs e)
        {
           

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonUcz_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioIteracja.Checked)
                {
                    Iteracja();
                 
                }
                else
                {
                    BladOkreslony();
                
                

                }
            }
            catch
            {

                MessageBox.Show("Wystąpił Błąd");
            }
        }

        void Iteracja()
        {
            graf graf1 = new graf();
            graf.struktura = struktura.Text.Trim();
            WczytajProbkeAlboWagi wczytaj = new WczytajProbkeAlboWagi();
            graf1.wagiZpliku = wczytaj.pobierzWagi(graf1.LiczbaKrawedzi(graf.struktura.Split(new char [] { ':'},StringSplitOptions.RemoveEmptyEntries)),wagi.Text.Trim());
            wczytaj= wczytaj.pobierzProbki(graf1.liczbaNodow(graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)),nazwaProbki.Text.Trim());
            graf1.wartosciWejscia = wczytaj.tablica[0];
            var d = wczytaj.wartosciZadane.First().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            for (int q = 0; q < wczytaj.wartosciZadane.First().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Length; q++)
                graf.wartosciZadaneNaWyjscia.Add(Convert.ToDouble(d[q].Replace('.', ',')));

            var node = graf1.AutomatyczneTworzenieNodow(graf.struktura);
            var node2 = graf1.PrzypiszWartosciDoNodow(graf1.wartosciWejscia, node);
            var kraw = graf1.ZwrocKrawedzie(node2, graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries));
            kraw = graf1.przypisWartosciDoKrawedzi(kraw, graf1.wagiZpliku);
         
            

            int r = 0;
            DateTimeOffset dto = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);
            Random random = new Random(Convert.ToInt32(dto.ToUnixTimeSeconds() / 2));
            List<string> historiaUczenia = new List<string>();
            for (int f = 0; f < Convert.ToInt32(zasiegIteracji.Text.Trim()); f++)
            {


                    r = random.Next(0,  wczytaj.tablica.Length);
                    for(int i=0; i< wczytaj.tablica[0].Length;i++)
                        node2[i].wartosc = Convert.ToDouble(wczytaj.tablica[r][i]);
                d = wczytaj.wartosciZadane[r].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                for (int w = 0; w < wczytaj.wartosciZadane.First().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Length; w++)
                    graf.wartosciZadaneNaWyjscia[w] = Convert.ToDouble(d[w].Replace('.', ','));


                var kraw1 = graf1.obliczWyjscia(node2, kraw, graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries));
                //Console.WriteLine("\nBłąd wynosi " + graf1.blad(graf.WartoscZadana, kraw1.Last().koniec.wartosc));
                kraw1 = graf1.wstecznaPropagacjaZmianaWag(kraw1);
                kraw = kraw1;
                foreach (Krawedz krawedz in kraw)
                {
                    historiaUczenia.Add(krawedz.ToString());
                }



            }
            krawedzs = kraw;
            dataGridView1.DataSource = krawedzs;

        }

        void BladOkreslony()
        {
            graf graf1 = new graf();
            graf.struktura = struktura.Text.Trim();
            WczytajProbkeAlboWagi wczytaj = new WczytajProbkeAlboWagi();
            graf1.wagiZpliku = wczytaj.pobierzWagi(graf1.LiczbaKrawedzi(graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)), wagi.Text.Trim());
            wczytaj = wczytaj.pobierzProbki(graf1.liczbaNodow(graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)), nazwaProbki.Text.Trim());
            graf1.wartosciWejscia = wczytaj.tablica[0];
            var d= wczytaj.wartosciZadane.First().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            for (int q=0;q<wczytaj.wartosciZadane.First().Split(new char[] {':' } , StringSplitOptions.RemoveEmptyEntries).Length; q++)
                graf.wartosciZadaneNaWyjscia.Add(Convert.ToDouble(d[q].Replace('.',',')));
            
            
            var node = graf1.AutomatyczneTworzenieNodow(graf.struktura);
            var node2 = graf1.PrzypiszWartosciDoNodow(graf1.wartosciWejscia, node);
            var kraw = graf1.ZwrocKrawedzie(node2, graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries));
            kraw = graf1.przypisWartosciDoKrawedzi(kraw, graf1.wagiZpliku);
     

            double srednia = 2;
            int r = 0;
            DateTimeOffset dto = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);
            Random random = new Random(Convert.ToInt32(dto.ToUnixTimeSeconds() / 2));
            List<double> ls = new List<double>();
           
            int t = 0;
            double srednia1=0;
            do
            {


                r = random.Next(0, wczytaj.tablica.Length);
                for (int i = 0; i < wczytaj.tablica[0].Length; i++)
                    node2[i].wartosc = Convert.ToDouble(wczytaj.tablica[r][i]);
                d = wczytaj.wartosciZadane[r].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                for (int w = 0; w < wczytaj.wartosciZadane.First().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Length; w++)
                    graf.wartosciZadaneNaWyjscia[w]=Convert.ToDouble(d[w].Replace('.', ','));



                var kraw1 = graf1.obliczWyjscia(node2, kraw, graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries));
                //Console.WriteLine("\nBłąd wynosi " + 
                var ile = Convert.ToInt32(graf.struktura.Split(new char[] {':' }, StringSplitOptions.RemoveEmptyEntries).Last());
                if (t < Convert.ToDouble(zIluProbekBlad.Text.Trim()))//liczyć ze wsio nodów do poprawy !!!!!!!!!!
                {
                    //srednia1 += Math.Abs(graf1.blad(graf.WartoscZadana, kraw1.Last().koniec.wartosc));
                     
                    for (int p = 0; p < Convert.ToInt32(graf.struktura.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Last()); p++)
                    {
                        srednia1 += Math.Abs(graf1.blad(graf.wartosciZadaneNaWyjscia[p], node2[node2.Count - ile - p-1].wartosc));
                        t++; 
                    }
                }
                else if (t >= Convert.ToDouble(zIluProbekBlad.Text.Trim()))
                {
                    srednia = Math.Abs(srednia1 / (Convert.ToDouble(zIluProbekBlad.Text.Trim())));
                    t = 0;
                    srednia1 = 0;

                }
                
                kraw1 = graf1.wstecznaPropagacjaZmianaWag(kraw1);
                kraw = kraw1;
              

                
                //0.1

            } while (Convert.ToDouble(BladPodany.Text.Trim())<=srednia);
            krawedzs = kraw;
            dataGridView1.DataSource = krawedzs;
           
        }

        private void Buttonzapisz_Click(object sender, EventArgs e)
        {
            Zapytanie zapytanie = new Zapytanie();
            zapytanie.ShowDialog();

            if(zapytanie.takNie)
            {
                string nazwaNowegoPliku = zapytanie.nazwa;


                FileStream fs;

                fs = new FileStream(nazwaNowegoPliku, FileMode.Create);
                fs.Close();
                StreamWriter sw = new StreamWriter(nazwaNowegoPliku);
                foreach (var d in krawedzs)
                {
                    sw.WriteLine(d.waga.ToString());
                }

                sw.Close();
                MessageBox.Show("Zapisano");

            }
            else
            {
                MessageBox.Show("Nie podano nazwy");
            }
        }
    }
}
