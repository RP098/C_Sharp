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
    public partial class DodajZawody : Form
    {
        public DodajZawody()
        {
            InitializeComponent();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {

            Dodaj_Zawody add = new Dodaj_Zawody();
            if (add.dodaj(name.Text.Trim(),content.Text.Trim(),shedule.Text.Trim(),Convert.ToDecimal(weapon_price.Text.Trim().Replace('.',',')),
                Convert.ToDecimal(contest_price.Text.Trim().Replace('.', ',')),Convert.ToInt32(avaiable_slots.Text.Trim())))
            {
                MessageBox.Show("Zawody dodane");
            }
            else
            {
                MessageBox.Show("Nie dodano sprawdź dane ");
            }
            
        }

        private void weapon_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
