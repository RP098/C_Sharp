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
    public partial class KNNDlaPojObiektu : Form
    {
        public KNNDlaPojObiektu()
        {
            InitializeComponent();
        }

        private void manhatan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void minkowskiego_CheckedChanged(object sender, EventArgs e)
        {
        

        }

        private void parametrM_TextChanged(object sender, EventArgs e)
        {

        }

        private void najmniejszychWynikow_Click(object sender, EventArgs e)
        {
            KnnKnajmniejszychWynikow knnKnajmniejszych = new KnnKnajmniejszychWynikow();
            this.Close();
            knnKnajmniejszych.Show();
        }

        private void knnSumNajmniejszych_Click(object sender, EventArgs e)
        {
            KnnSumaKnajmniejszychWartosci knn = new KnnSumaKnajmniejszychWartosci();
            this.Close();
            knn.Show();
        }

        private void KNNDlaPojObiektu_Load(object sender, EventArgs e)
        {

        }
    }
}
