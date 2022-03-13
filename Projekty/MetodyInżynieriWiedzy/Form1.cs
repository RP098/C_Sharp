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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Zad1Normalizuj_Click(object sender, EventArgs e)
        {
            Zad1Operacjanadanych zad1 = new Zad1Operacjanadanych();
            zad1.Show();
        }

        private void button1_Click(object sender, EventArgs e)//walidator
        {
            WalidatorPliku walidator = new WalidatorPliku();
            walidator.Show();

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

        private void KnnPojObiekt_Click(object sender, EventArgs e)
        {
            KNNDlaPojObiektu kNNDlaPoj = new KNNDlaPojObiektu();
            kNNDlaPoj.Show();
        }

        private void KnnBazaProbek_Click(object sender, EventArgs e)
        {
            KnnDlaBazyProbek knnDlaBazy = new KnnDlaBazyProbek();
            knnDlaBazy.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZadanieDodatkowe zadanie = new ZadanieDodatkowe();
            zadanie.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\Asus\\source\\repos\\MetodyInżynieriWiedzy\\bin\\Debug");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            UsunKolumne usunKolumne = new UsunKolumne();
            usunKolumne.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
