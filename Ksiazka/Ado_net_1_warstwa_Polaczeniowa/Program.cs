using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace Ado_net_1_warstwa_Polaczeniowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.factoryData();
            program.connectToDB();
            program.DataReader();
            //program.InsertData();
            //program.DeleteData();
            //program.ParameterQuery(5,"Czerwony","Audi","Speed Car"); 

            Console.ReadLine();
        }

        private void ParameterQuery(int id, string color, string make,string CarName)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;
                connection.Open();
                string sql = "Insert Into Inventory" +
                    "(Make,Color,CarName)" +
                    "Values" +
                    "(@make,@Color,@CarName)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    SqlParameter parameter = new SqlParameter()
                    {
                        ParameterName = "@Make",
                        Value = make,
                        SqlDbType = SqlDbType.NVarChar,
                        Size = 20

                    };

                    command.Parameters.Add(parameter);
                     parameter = new SqlParameter()
                    {
                        ParameterName = "@Color",
                        Value = color,
                        SqlDbType = SqlDbType.NVarChar,
                        Size = 20

                    };
                    command.Parameters.Add(parameter);
                    parameter = new SqlParameter()
                    {
                        ParameterName = "@CarName",
                        Value = CarName,
                        SqlDbType = SqlDbType.NVarChar,
                        Size = 20

                    };
                    command.Parameters.Add(parameter);
                    Console.WriteLine( command.ExecuteNonQuery());
                }
            }
        }

        void factoryData()
        {

        Console.WriteLine("Data Provider Factories");

        string dataProvider = ConfigurationManager.AppSettings["provider"];
        string connectionString = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;

        DbProviderFactory factory = DbProviderFactories.GetFactory(dataProvider);
            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    Console.WriteLine("Connection error");
                    return;
                }
                Console.WriteLine($"Your connection object is a:{connection.GetType().Name}");
                connection.ConnectionString = connectionString;
                connection.Open();
                DbCommand command = factory.CreateCommand();
                if (command == null)
                {
                    Console.WriteLine("Error command");
                    return;
                }
                Console.WriteLine($"Your command object is a:{command.GetType().Name}");
                command.Connection = connection;
                command.CommandText = "Select * From Inventory";
                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    Console.WriteLine($"Your data reader object is a:{dataReader.GetType().Name}");
                    while (dataReader.Read())
                    {
                        Console.WriteLine($"Car #{dataReader["CarId"]} is a {dataReader["Make"]}.".Trim());
                    }
                    
                }
            }

        }
        void connectToDB()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;
                connection.Open();
                string sql = "Select * From inventory";
                SqlCommand sqlCommand = new SqlCommand(sql,connection);
                using (SqlDataReader sqlDataReader=sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine($"Make: {sqlDataReader["Make"]}," +
                            $"CarName: {sqlDataReader["Color"]}.".Trim());
                    }
                }

            }

        }

        void DataReader()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;
                connection.Open();
                string sql = "Select * From inventory";
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Console.WriteLine($"Make: {dataReader["Make"]}," +
                          $"CarName: {dataReader["CarName"]}."+
                          $"Color: {dataReader["Color"]}".Trim());
                    }
                }

            }
        }
        void InsertData()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;
                connection.Open();
                string sql = "Insert Into inventory (Make,Color,CarName) Values('BMW','White','Good')";
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    Console.WriteLine(sqlCommand.ExecuteNonQuery());

                }


            }
        }

        void DeleteData()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;
                connection.Open();
                string sql = "Delete from Inventory where CarId=2;";
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    Console.WriteLine(sqlCommand.ExecuteNonQuery());

                }


            }
        }

    }
}
