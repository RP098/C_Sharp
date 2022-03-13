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
    public partial class Zapytanie : Form
    {
        public Zapytanie()
        {
            InitializeComponent();
        }
        public bool takNie = false;
        public string nazwa="Waga.txt";

        private void Zapytanie_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            takNie= true;
            nazwa = textBox1.Text.Trim();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            takNie = false;
            this.Close();
        }
    }
}
