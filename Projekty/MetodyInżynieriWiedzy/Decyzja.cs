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
    public partial class Decyzja : Form
    {
        public Decyzja()
        {
            InitializeComponent();
        }

        public Decyzja(string [,] obiekt,string decyzja )
        {
          

            InitializeComponent();
            textBox1.Text = decyzja;


            for (int j =0; j<obiekt.Length;j++)
                textBox2.Text += obiekt[0, j]+ " "; 

            
            
        }
        private void Decyzja_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
