using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Michelin_Garda_2021
{
    class updateWynikiInbaza
    {
        public bool ZmienDane(long idresultatu, int result,int place,int inside,string comment)
        {
            try
            {
                string MyConnection2 = "SERVER = localhost; PORT = 3306; DATABASE = towarzysze; UID = " + Login.user + "; " + "PASSWORD = " + Login.password + "; ";
                /*
                UPDATE Customers
                SET ContactName = 'Alfred Schmidt', City= 'Frankfurt'
                WHERE CustomerID = 1; 

                 */

                string Query = "UPDATE results " +
                    "SET result = '" + result.ToString()+ "', place='" + place + "', inside='" + inside + "', comments='" + comment  + "'"
                    + "Where id= '" + idresultatu +"'";

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
