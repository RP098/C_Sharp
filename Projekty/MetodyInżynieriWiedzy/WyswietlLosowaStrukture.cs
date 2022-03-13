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
                    richTextBox1.Text += infoOstrukturze[i].ToString()+"\n";

            richTextBox1.Text += "Pamiętaj ostatnia wartość oznacza wartości antentki \n" +
                "Która to przestrzeń    Wejście  Wyjście te z antentką  wartosc struktura np 1-2  \n"
                 +
                "0                                0            0                                 0.6543241 " + "\n"
                 +
                "0                                0            1                                 0.8532423 " + "\n"
               +"Która to przestrzeń          Antentka numer do którego nalezy   wartosc antentki \n"
                +
                "0                                1            0                                             0.6543241 " + "\n" +
                
                "0                                1            1                                             0.8532423 " + "\n";
             
            for (int i = 0; i < infoOstrukturze.Length - 1; i++)
            {
                int wymiar2 = (infoOstrukturze[i] + 1);
                int wymiar3 = infoOstrukturze[i + 1];
                richTextBox1.Text+=("miejsce " + i + "\n");
                for (int j = 0; j < wymiar2; j++)
                {


                    for (int k = 0; k < wymiar3; k++)
                    {

                        richTextBox1.Text += (i+" "+j+" "+k+" "+
                    struktura[i][j][k] +"\n" );

                    }
                    richTextBox1.Text += "\n";

                }
                richTextBox1.Text += "\n";
            }

            richTextBox1.Text += "\n";



        }
        

        private void WyswietlLosowaStrukture_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
