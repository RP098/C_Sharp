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

using System.Reflection;
using IronXL;

namespace WspolpracaZCOM_EXEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Car> cars=null;
        private void Form1_Load(object sender, EventArgs e)
        {
            cars = new List<Car> {new Car("Mercedes",50,2000),
            new Car("Opel",20,20000),
            new Car("Dacia",10,200),
            new Car("BMW",150,20)
            };
            UpdateGrid();
        }
        void UpdateGrid()
        {
            dataGridCars.DataSource = null;
            dataGridCars.DataSource = cars;
        }

        private void AddInventoryButton_Click(object sender, EventArgs e)
        {
            CarDialog carDialog= new CarDialog();
            carDialog.ShowDialog();
            if (carDialog.IsAddCar == true)
            {
                cars.Add(carDialog.car);
                UpdateGrid();
            }
        }

        private void Export_to_Excel_Button_Click(object sender, EventArgs e)
        {
            ExportToExcel(cars);
        }

         void ExportToExcel(List<Car> cars)
        {
            WorkBook xlsWorkbook = WorkBook.Create(ExcelFileFormat.XLS);
            xlsWorkbook.Metadata.Author = "IronXL";
            WorkSheet worksheet = xlsWorkbook.CreateWorkSheet("new_sheet");

            worksheet["A1"].Value="Car name";
            worksheet[ "B1"].Value = "Speed Car";
            worksheet[ "C1"].Value = "Meter Status";
            int row = 1;
            foreach (var item in cars)
            {
                row++;
                worksheet[ "A"+row.ToString()].Value = item.Name;
                worksheet[ "B" + row.ToString()].Value = item.SpeedCar;
                worksheet[ "C" + row.ToString()].Value = item.mileage;
                worksheet.SaveAs(string.Format(@"{0}\Inventory.xlsx", Environment.CurrentDirectory));
                
               
            }
            MessageBox.Show("The inventory file has been saved Export Complete");
            xlsWorkbook.Close();
        }
    }
}
