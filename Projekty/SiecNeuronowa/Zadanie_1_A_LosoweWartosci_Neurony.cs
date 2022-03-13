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
    public partial class Zadanie_1_A_LosoweWartosci_Neurony : Form
    {
        public Zadanie_1_A_LosoweWartosci_Neurony()
        {
            InitializeComponent();
        }

        private void struktura_TextChanged(object sender, EventArgs e)
        {

        }

        private void generuj_Click(object sender, EventArgs e)
        {
            try
            {
                var pomomocnicza_Zmienna_strukturaWarstw = struktura.Text.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                int[] infoOstrukturze = new int[pomomocnicza_Zmienna_strukturaWarstw.Length];
                if (pomomocnicza_Zmienna_strukturaWarstw.Length == 1)
                {
                    Exception exception = new Exception();
                    throw exception;

                }
                for (int i = 0; i < pomomocnicza_Zmienna_strukturaWarstw.Length; i++)
                {
                    infoOstrukturze[i] = Convert.ToInt32(pomomocnicza_Zmienna_strukturaWarstw[i]);
                }
                Generuj.ZakresMin =String.IsNullOrEmpty(ZakresMin.Text.Trim())? 0 : Convert.ToInt32(ZakresMin.Text.Trim());
                Generuj.ZakresMax =String.IsNullOrEmpty(zakresMax.Text.Trim())? 10 : Convert.ToInt32(zakresMax.Text.Trim());

                Generuj generuj = new Generuj(infoOstrukturze);
                struktura.Clear();
                MessageBox.Show("Wygenerowano");
                ZapiszStrukture zapiszStrukture = new ZapiszStrukture(generuj.strukturaNeuronow, infoOstrukturze);
                zapiszStrukture.Show();
                this.Close();
            }
            catch
            {


                MessageBox.Show("Podane Błędne Dane !!!\n" +
                                "Popraw Się :) \n" +
                                "Pamiętaj Liczby Mają Być Całkowite A Separator Myślnik");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zakresMax_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
