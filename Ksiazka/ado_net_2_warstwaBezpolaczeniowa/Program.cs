using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace ado_net_2_warstwaBezpolaczeniowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with data set");
            var carsInventoryDs = new DataSet("Car inventory");
            carsInventoryDs.ExtendedProperties["TimeStamp"] = DateTime.Now;
            carsInventoryDs.ExtendedProperties["DataSetID"] = Guid.NewGuid();
            carsInventoryDs.ExtendedProperties["Company"] = "MiCOM Company";
            //FillDataSet(carsInventoryDs);
            //PrintDataSet(carsInventoryDs);
            //SaveDataSetXML(carsInventoryDs);
            //LoadDataSetXML(carsInventoryDs);
            // PrintDataSet(carsInventoryDs);
            //SaveDataSetBinary(carsInventoryDs);
            carsInventoryDs=LoadDataSetBinary(carsInventoryDs);
            PrintDataSet(carsInventoryDs);
            Console.ReadLine();


        }

        private static DataSet LoadDataSetBinary(DataSet carsInventoryDs)
        {
            
            using (var fs = new FileStream("BinaryCars.bin", FileMode.Open))
            {
                var bFormat = new BinaryFormatter();
                carsInventoryDs=(DataSet)bFormat.Deserialize(fs);
                
               
            }
            return carsInventoryDs;
        }

        private static void SaveDataSetBinary(DataSet carsInventoryDs)
        {
            carsInventoryDs.RemotingFormat = SerializationFormat.Binary;
            using (var fs = new FileStream("BinaryCars.bin", FileMode.Create))
            {
                var bFormat = new BinaryFormatter();
                bFormat.Serialize(fs, carsInventoryDs);
            }
        }

        private static void LoadDataSetXML(DataSet carsInventoryDs)
        {
            carsInventoryDs.ReadXml("carsDataSet.xml");
        }

        private static void SaveDataSetXML(DataSet carsInventoryDs)
        {
            carsInventoryDs.WriteXml("carsDataSet.xml");
            carsInventoryDs.WriteXmlSchema("carsDataSet.xsd");
        }

        private static void PrintDataSet(DataSet carsInventoryDs)
        {
            Console.WriteLine($"Data set is named: {carsInventoryDs.DataSetName}");
            foreach (DictionaryEntry item in carsInventoryDs.ExtendedProperties)
            {
                Console.WriteLine($"Key = {item.Key}, Values = {item.Value}");
            }
            Console.WriteLine();
            foreach (DataTable item in carsInventoryDs.Tables)
            {
                Console.WriteLine($"{item.TableName} Table:");
                for (int i = 0; i < item.Columns.Count; i++)
                {
                    Console.WriteLine($"{item.Columns[i].ColumnName}\t");
                }
                Console.WriteLine("\n-------------------------------------");
                for (int i = 0; i < item.Rows.Count; i++)
                {
                    for (int j = 0; j < item.Columns.Count; j++)
                    {
                        Console.Write($"{item.Rows[i][j]} \t");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void FillDataSet(DataSet carsInventoryDs)
        {
            var carIdColumn = new DataColumn("CarID", typeof(int))
            {
                Caption = "Car ID",
                ReadOnly = true,
                AllowDBNull = false,
                Unique = true,
                AutoIncrementSeed=1,
                AutoIncrementStep=1

            };

            var carMakeColumn = new DataColumn("Make", typeof(string));
            var carColorColumn = new DataColumn("Color", typeof(string));
            var carNameColumn = new DataColumn("CarName", typeof(string))
            {
                Caption  = "Car Name"
            };
            var inventoryTable = new DataTable("Inventory");
            inventoryTable.Columns.AddRange(new[] {carMakeColumn,carColorColumn,carNameColumn});
            DataRow carRow = inventoryTable.NewRow();
            
            carRow["Make"] = "BMW";
            carRow["Color"] = "Black";
            carRow["CarName"] = "Hamlet";
            inventoryTable.Rows.Add(carRow);
            carRow = inventoryTable.NewRow();
            carRow[0] = "Saab";
            carRow[1] = "Red";
            carRow[2] = "Sea Breeze";
            inventoryTable.Rows.Add(carRow);

            carsInventoryDs.Tables.Add(inventoryTable);

        }

        static void ManipulateDataRowState()
        {
            var temp = new DataTable("Temp");
            temp.Columns.Add(new DataColumn("TempColumn",typeof(int)));
            
            var row = temp.NewRow();
            Console.WriteLine($"After calling NewRow() : {row.RowState}");

            temp.Rows.Add(row);
            Console.WriteLine($"After calling AddRow() : {row.RowState}");

            row["TempColumn"] = 10;
            Console.WriteLine($"After first assigment : {row.RowState}");

            temp.AcceptChanges();
            Console.WriteLine($"After calling AcceptChanges : {row.RowState}");

            row["TempColumn"] = 11;
            Console.WriteLine($"After first assigment : {row.RowState}");

            temp.Rows[0].Delete();
            Console.WriteLine($"After calling Delete : {row.RowState}");



        }
    }
}
