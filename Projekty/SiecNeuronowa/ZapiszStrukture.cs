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
    public partial class ZapiszStrukture : Form
    {
        double[][][] struktura;
        int[] infoOstrukturze;
        public ZapiszStrukture()
        {
            InitializeComponent();
        }
        public ZapiszStrukture(double[][][] struktura, int[] infoOstrukturze)
        {
            this.struktura = struktura;
            this.infoOstrukturze = infoOstrukturze;

            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Zadanie_1_A_LosoweWartosci_Neurony zadanie_1_A_LosoweWartosci_ = new Zadanie_1_A_LosoweWartosci_Neurony();
            zadanie_1_A_LosoweWartosci_.Show();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int suma = 0;
                string pierwszy = "";
                int d;
                for (d = 0; d < infoOstrukturze.Length - 1; d++)
                {
                    suma += (infoOstrukturze[d] + 1) * infoOstrukturze[d + 1];

                    pierwszy += infoOstrukturze[d].ToString() + ":";

                }

                pierwszy += infoOstrukturze[d].ToString();
                int l = 1;
                string[] daneDozapisu = new string[suma + 1];
                daneDozapisu[0] = pierwszy;
                for (int i = 0; i < infoOstrukturze.Length - 1; i++)
                {
                    int wymiar2 = (infoOstrukturze[i] + 1);
                    int wymiar3 = infoOstrukturze[i + 1];

                    for (int j = 0; j < wymiar2; j++)
                    {


                        for (int k = 0; k < wymiar3; k++)
                        {

                            daneDozapisu[l++] = (
                            struktura[i][j][k].ToString());

                        }


                    }


                }

                if (!zapisDoplikuWariant1(nazwaStruktury.Text.Trim().ToString(), daneDozapisu, suma + 1))
                {
                    Exception exception = new Exception();
                    throw exception;

                }

                MessageBox.Show("Zapisano Strukturę ");

            }
            catch
            {

                MessageBox.Show("Zapis nie powiódł się :(");

            }
        }

        private void nazwaStruktury_TextChanged(object sender, EventArgs e)
        {

        }
        protected bool zapisDoplikuWariant1(String nazwa, string[] ciagZapis, int dlugosc)
        {
            try
            {
                string nazwaNowegoPliku = nazwa;


                FileStream fs;

                fs = new FileStream(nazwaNowegoPliku, FileMode.Create);
                fs.Close();
                StreamWriter sw = new StreamWriter(nazwaNowegoPliku);
                for (int i = 0; i < dlugosc; i++)
                {
                    sw.WriteLine(ciagZapis[i]);

                }

                sw.Close();
            }
            catch
            {

                return false;
            }
            return true;
        }

    }
}
