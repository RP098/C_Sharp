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
    public partial class DodajUzytkownika : Form
    {
        public DodajUzytkownika()
        {
            InitializeComponent();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            Dodaj_Uzytkownika add = new Dodaj_Uzytkownika();
            
            if (add.dodaj(email.Text.Trim(), haslo.Text.Trim(), name.Text.Trim() ))
            {
                MessageBox.Show("Użytkownik dodany");
            }
            else
            {
                MessageBox.Show("Nie dodano użytkownika ");
            }
         
        }

        private void haslo_TextChanged(object sender, EventArgs e)
        {

        }

        private void DodajUzytkownika_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
