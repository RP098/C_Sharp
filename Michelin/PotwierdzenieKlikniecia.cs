using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Michelin_Garda_2021
{
    public partial class PotwierdzenieKlikniecia : Form
    {
        public string tekstKomunikatu="Potwierdz Modyfikacje"; 
        public bool tak_zmien = false;
       
        public PotwierdzenieKlikniecia()
        {
            
            InitializeComponent();
            label1.Text = this.tekstKomunikatu;
        }
        public PotwierdzenieKlikniecia(string tekst)
        {

            InitializeComponent();
            label1.Text = tekst;
        }
        public void tak_Click(object sender, EventArgs e)
        {
            this.tak_zmien = true;
            this.Close();
        }

        private void nie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PotwierdzenieKlikniecia_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
