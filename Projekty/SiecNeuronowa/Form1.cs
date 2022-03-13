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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generuj_Click(object sender, EventArgs e)
        {
            Zadanie_1_A_LosoweWartosci_Neurony zadanie_1_A = new Zadanie_1_A_LosoweWartosci_Neurony();
            zadanie_1_A.Show();
        }

        private void odczytaj_Click(object sender, EventArgs e)
        {
            OdczytajStrukture odczytajStrukture = new OdczytajStrukture();
            odczytajStrukture.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ucz ucz = new Ucz();
            ucz.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pytaj pytaj = new Pytaj();
            pytaj.Show();
        }
    }
}
