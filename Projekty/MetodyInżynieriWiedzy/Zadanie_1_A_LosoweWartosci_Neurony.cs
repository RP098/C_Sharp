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
    public partial class Zadanie_1_A_LosoweWartosci_Neurony : System.Windows.Forms.Form
    {
        public Zadanie_1_A_LosoweWartosci_Neurony()
        {
            InitializeComponent();
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
                for (int i = 0; i<pomomocnicza_Zmienna_strukturaWarstw.Length;i++ )
                {
                    infoOstrukturze[i] =Convert.ToInt32( pomomocnicza_Zmienna_strukturaWarstw[i]);
                }
                Generuj generuj = new Generuj(infoOstrukturze);
                struktura.Clear();
                MessageBox.Show("Wygenerowano");
                ZapiszStrukture zapiszStrukture = new ZapiszStrukture(generuj.strukturaNeuronow,infoOstrukturze);
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

        private void struktura_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zadanie_1_A_LosoweWartosci_Neurony_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
