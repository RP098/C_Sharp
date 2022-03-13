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
    public partial class OdczytajStrukture : System.Windows.Forms.Form
    {
        public OdczytajStrukture()
        {
            InitializeComponent();
        }

        private void OdczytajStrukture_Load(object sender, EventArgs e)
        {

        }

        private void odczytaj_Click(object sender, EventArgs e)
        {
            try
           {
                WczytajPlik wczytaj = new WczytajPlik(NazwaStruktury.Text.Trim().ToString(),':');
                WczytajPlik czyIstnieje = wczytaj.sprawdzCzyIstnieje(wczytaj);
                if (!czyIstnieje.czyIstnieje)
                { Exception exception = new Exception();
                    throw exception;
                }
                StreamReader streamReader = new StreamReader(wczytaj.nazwa);
                var pominfoOstrukturze = streamReader.ReadLine().Split(new char[] {':' },StringSplitOptions.RemoveEmptyEntries);
                int[] informacjOstrukturze = new int[pominfoOstrukturze.Length];
                for(int i=0;i<pominfoOstrukturze.Length;i++)
                {
                    informacjOstrukturze[i] = Convert.ToInt32(pominfoOstrukturze[i]);


                }
                int suma = 0;
                for (int d = 0; d < informacjOstrukturze.Length - 1; d++)
                {
                    suma += (informacjOstrukturze[d] + 1) * informacjOstrukturze[d + 1];

                   

                }
                streamReader.Close();
                wczytaj.dlugosc = suma;
                wczytaj.tablica = wczytaj.pobierzDane(wczytaj);
                wczytaj.separator = ':';
                double[][][] struktura= Odczytaj(informacjOstrukturze, wczytaj.tablica);
                MessageBox.Show("Odczytano");
                WyswietlLosowaStrukture wyswietlLosowaStrukture = new WyswietlLosowaStrukture(struktura, informacjOstrukturze);
                wyswietlLosowaStrukture.Show();
                this.Close();
                }
            catch
            {
                MessageBox.Show("Wystąpił Błąd wprowadz poprawne dane");
            }
        }

        public double [][][] Odczytaj(int [] infoOstrukturze, string [] wartosci)
        {
            int wymiar1 = infoOstrukturze.Length - 1;
            double[][][] struktura=new double[wymiar1][][];
                


                int l = 1;
            
                
                for (int i = 0; i < infoOstrukturze.Length - 1; i++)
                {
                    int wymiar2 = (infoOstrukturze[i] + 1);
                    int wymiar3 = infoOstrukturze[i + 1];
                    struktura[i] = new double[wymiar2][];
                for (int j = 0; j < wymiar2; j++)
                    {

                    
                    struktura[i][j] = new double[wymiar3];
                    for (int k = 0; k < wymiar3; k++)
                        {
                        var wartosciString = wartosci[l++].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                        struktura[i][j][k]=Convert.ToDouble(wartosciString.Last());

                        }


                    }


                }






                return struktura;
            



        }




        private void NazwaStruktury_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
