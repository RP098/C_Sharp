using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Michelin_Garda_2021
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            Logowanie_ login = new Logowanie_();
            Logowanie_.user = loginBut.Text.Trim();
            Logowanie_.password = haslo.Text;
            if (login.polaczenie())
            {
                Thread StaticCaller = new Thread(
              new ThreadStart(Program.ZarzadzanieListaUzytkownikow));


                StaticCaller.Start();
                Logowanie_.conn.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Podano błędne dane");

            }
        }

        private void Logowanie_Load(object sender, EventArgs e)
        {

        }
    }
}
