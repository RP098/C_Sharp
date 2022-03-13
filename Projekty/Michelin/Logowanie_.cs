using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Michelin_Garda_2021
{
    public class Logowanie_
    {
        public static string user;
        public static string password;
        public static MySqlConnection conn;
        
        public bool polaczenie()
        {

            string connString = "SERVER=localhost;PORT=3306;DATABASE=towarzysze;UID=" + Logowanie_.user + ";" + "PASSWORD=" + Logowanie_.password + ";";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
               
            }
            catch
            {
                return false;
            }

            return true;
        }

    }
}
