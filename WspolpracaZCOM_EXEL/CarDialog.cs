using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hermetyzacja;
namespace WspolpracaZCOM_EXEL
{
    public partial class CarDialog : Form
    {
        public CarDialog()
        {
            InitializeComponent();
        }
        public Car car { get; set; }
        public bool IsAddCar { get; set; } = false;
        private void AddCar_Click(object sender, EventArgs e)
        {
            try
            {
                car = new Car(textBoxCarName.Text, int.Parse(textBoxCarSpeed.Text), int.Parse(textBoxMeterStatus.Text));
                IsAddCar = true;
                MessageBox.Show("Car is Add");
            }
            catch (Exception ex)
            {
                IsAddCar = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
               
                this.Close();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
