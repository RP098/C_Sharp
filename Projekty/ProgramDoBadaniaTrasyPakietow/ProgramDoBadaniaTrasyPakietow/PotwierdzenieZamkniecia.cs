using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramDoBadaniaTrasyPakietow
{
    public partial class PotwierdzenieZamkniecia : Form
    {
        public PotwierdzenieZamkniecia()
        {
            InitializeComponent();
        }
        public bool zamknij = false;
        private void PotwierdzenieZamkniecia_Load(object sender, EventArgs e)
        {

        }

        private void tak_Click(object sender, EventArgs e)
        {
            zamknij = true;
            this.Close();
        }

        private void nie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
