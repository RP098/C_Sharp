using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet_W_winforms
{
    public partial class MainForm : Form
    {
        List<Car> listCars = null;
        DataTable inventoryTable = new DataTable();
        public MainForm()
        {
           

            listCars = new List<Car> 
            { 
            new Car{Id=1,CarName="Chucky",Make="BMW",Color="Green"},
            new Car{Id=2,CarName="Tiny",Make="Opel",Color="White"},
            new Car{Id=3,CarName="Ami",Make="Ford",Color="Tan"},
            new Car{Id=4,CarName="Pain",Make="Jeep",Color="Pink"},
            new Car{Id=5,CarName="Fred",Make="BMW",Color="Green"},
            new Car{Id=6,CarName="Sidd",Make="BMW",Color="Black"},
            new Car{Id=7,CarName="Mel",Make="Colt",Color="Red"},
            new Car{Id=8,CarName="Sarah",Make="Corsa",Color="Black"} 
            };
            InitializeComponent();
            CreateDataTable();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        void CreateDataTable()
        {
            var CarIdColumn = new DataColumn("Id", typeof(int));
            var CarNameColumn = new DataColumn("CarName", typeof(string)) { Caption = "Car Name"};
            var MakeColumn = new DataColumn("Make", typeof(string));
            var ColorColumn = new DataColumn("Color", typeof(string));

            inventoryTable.Columns.AddRange(new[] { CarIdColumn, CarNameColumn, MakeColumn, ColorColumn });
            foreach (var item in listCars)
            {
                var newRow = inventoryTable.NewRow();
                newRow[0] = item.Id;
                newRow[1] = item.CarName;
                newRow[2] = item.Make;
                newRow[3] = item.Color;
                inventoryTable.Rows.Add(newRow);
                dataGridViewCarInventory.DataSource=inventoryTable;
            }
            


        }

        private void dataGridViewCarInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] rowToDelete = inventoryTable.Select($"Id={int.Parse(textBoxDelete.Text)}");
                rowToDelete[0].Delete();
                inventoryTable.AcceptChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            StringBuilder filter = new StringBuilder();
            filter.Append( $"Make='{textBoxView.Text}'");
            DataRow [] dataRowMake = inventoryTable.Select(filter.ToString());
            if (dataRowMake.Length == 0)
                MessageBox.Show("Sorry, no cars...");
            else
            { StringBuilder dateRow = new StringBuilder();
                for (int i = 0; i < dataRowMake.Length; i++)
                {
                    dateRow.Append(dataRowMake[i]["CarName"] + "\n");
                }
                MessageBox.Show("All element \n" + dateRow.ToString());

            }
            
        }
    }
}
