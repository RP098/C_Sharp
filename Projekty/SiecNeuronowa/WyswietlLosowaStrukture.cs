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
    public partial class WyswietlLosowaStrukture : Form
    {
        double[][][] struktura;
        int[] infoOstrukturze;
        public WyswietlLosowaStrukture()
        {
            InitializeComponent();
        }
        public WyswietlLosowaStrukture(double[][][] struktura, int[] infoOstrukturze)
        {
            this.struktura = struktura;
            this.infoOstrukturze = infoOstrukturze;

            InitializeComponent();

            for (int i = 0; i < infoOstrukturze.Length; i++)
                if (i < infoOstrukturze.Length - 1)
                    richTextBox1.Text += infoOstrukturze[i].ToString() + "-";
                else
                    richTextBox1.Text += infoOstrukturze[i].ToString() + "\n";

          

            for (int i = 0; i < infoOstrukturze.Length - 1; i++)
            {
                int wymiar2 = (infoOstrukturze[i] + 1);
                int wymiar3 = infoOstrukturze[i + 1];
                richTextBox1.Text += ("miejsce " + i + "\n");
                for (int j = 0; j < wymiar2; j++)
                {


                    for (int k = 0; k < wymiar3; k++)
                    {

                        richTextBox1.Text += (struktura[i][j][k] + "\n");

                    }
                    richTextBox1.Text += "\n";

                }
                richTextBox1.Text += "\n";
            }

            richTextBox1.Text += "\n";



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
