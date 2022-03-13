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
    public partial class Zad1Zapisz : System.Windows.Forms.Form
    {
        public WczytajPlik wczytaj;
        norm2 normalizujprzed;
        public Zad1Zapisz()
        {
            InitializeComponent();
        }
        public Zad1Zapisz(WczytajPlik wczytaj, norm2 normalizujprzed)
        {
            this.wczytaj = wczytaj;
            this.normalizujprzed = normalizujprzed;
            InitializeComponent();
        }
        private void Zad1Zapisz_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Zad1Operacjanadanych zad1Operacjanadanych = new Zad1Operacjanadanych();
          
            zad1Operacjanadanych.Show();
           



        }
        private void zapiszWariant1_Click(object sender, EventArgs e)
        {
            try
            {
                zapiszWariant1 zapisz = new zapiszWariant1(normalizujprzed, wczytaj);
                if (!zapisz.czyZapisano)
                { Exception exception = new Exception();
                   throw exception ;
                }

                MessageBox.Show("Zapisano");
            }
            catch
            {
                MessageBox.Show("Nie zapisano");
            }
        }

        private void zapiszWariant2_Click(object sender, EventArgs e)
        {
            try
            {
                zapiszWariant2 zapisz = new zapiszWariant2(normalizujprzed, wczytaj);
                if (!zapisz.czyZapisano)
                {
                    Exception exception = new Exception();
                    throw exception;
                }
                MessageBox.Show("Zapisano");
            }
            catch
            {
                MessageBox.Show("Nie zapisano");
            }
        }

        private void zapiszWariant3_Click(object sender, EventArgs e)
        {
          try
            {
               zapiszWariant3 zapisz = new zapiszWariant3(normalizujprzed, wczytaj);
                if (!zapisz.czyZapisano)
                {
                    Exception exception = new Exception();
                    throw exception;
                }
                MessageBox.Show("Zapisano");
            }
            catch
            {
                MessageBox.Show("Nie zapisano");
            }
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\Asus\\source\\repos\\MetodyInżynieriWiedzy\\bin\\Debug");
        }
    }
}
