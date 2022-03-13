using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Michelin_Garda_2021
{
  public  class ZmienUzytkownikow_w_Bazie
    {

        public bool ZmienDane(int id,string nazwa ,string email, string haslo)
        {
            try
            {
                string MyConnection2 = "SERVER = localhost; PORT = 3306; DATABASE = towarzysze; UID = " + Logowanie_.user + "; " + "PASSWORD = " + Logowanie_.password + "; ";
                /*
                UPDATE Customers
                SET ContactName = 'Alfred Schmidt', City= 'Frankfurt'
                WHERE CustomerID = 1; 

                 */

                string Query = "UPDATE users " +
                    "SET name = '" + nazwa + "', email='" + email + "', password='" + haslo + "'" + "Where id= '" + id + "'";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                MyConn2.Close();
            }
            catch
            {

                return false;
            }
            return true;
        }
    }
}
