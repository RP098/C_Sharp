using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Michelin_Garda_2021
{
    class DeleteZawodyInBaza
    {
        public bool UsunZawody(int id)
        {
            try
            {
                string MyConnection2 = "SERVER = localhost; PORT = 3306; DATABASE = towarzysze; UID = " + Login.user + "; " + "PASSWORD = " + Login.password + "; ";
                /*
               DELETE FROM `table_name` [WHERE condition];

                 */

                string Query = "DELETE FROM contests Where id= '" + id + "'";

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
