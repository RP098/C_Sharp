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
    public partial class DodajKonkurencje : Form
    {

        decimal WlasnaTaryfaA =0;
        decimal WlasnaTaryfaB =0;
        decimal KlubTaryfaA   =0;
        decimal KlubTaryfaB   =0;
        public DodajKonkurencje()
        {
            InitializeComponent();
        }

        private void wlasna_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            addKonkurencja add = new addKonkurencja();
         
                WlasnaTaryfaA = wlasnaA.Text.Trim().Length>0 ? Convert.ToDecimal(wlasnaA.Text.Trim()):0;    
                WlasnaTaryfaB = wlasnaB.Text.Trim().Length > 0 ? Convert.ToDecimal(wlasnaB.Text.Trim()):0;
                KlubTaryfaA = klubA.Text.Trim().Length >0 ? Convert.ToDecimal(klubA.Text.Trim()):0;
                KlubTaryfaB = klubB.Text.Trim().Length >0 ? Convert.ToDecimal(klubB.Text.Trim()):0;
            if (add.dodaj(name.Text.Trim(), competition_code.Text.Trim(), content.Text.Trim(),jakaBron(), Convert.ToInt32(avaiable_slots.Text.Trim()),WlasnaTaryfaA,WlasnaTaryfaB,KlubTaryfaA,KlubTaryfaB))
            {
                MessageBox.Show("Konkurencja Dodana");
            }
            else
            {
                MessageBox.Show("Nie dodano Konkurencji ");
            }
        

            
        }
        konkurencje.used_weapon jakaBron()
        {
            if (wlasna.Checked)
                return konkurencje.used_weapon.własna;
            else if (klubowa.Checked)
                return konkurencje.used_weapon.klubowa;
            else 
                return konkurencje.used_weapon.dowolna;
        }

        private void wybor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wartosc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
