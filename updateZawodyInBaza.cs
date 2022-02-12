using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Michelin_Garda_2021
{
    class updateZawodyInBaza
    {
        public bool ZmienDane(int id,string name, string content, string shedule, decimal Entry_fee_outside_the_club, decimal Entry_fee_club_member, int avaible_slots)
        {
            try
           {
                string MyConnection2 = "SERVER = localhost; PORT = 3306; DATABASE = towarzysze; UID = " + Login.user + "; " + "PASSWORD = " + Login.password + "; ";
                /*
                UPDATE Customers
                SET ContactName = 'Alfred Schmidt', City= 'Frankfurt'
                WHERE CustomerID = 1; 

                 */

                string Query = "UPDATE contests " +
                    "SET name = '" +name + "', content='" + content + "', schedule='" + shedule + "', Entry_fee_outside_the_club='" + Entry_fee_outside_the_club + "', Entry_fee_club_member = '" + Entry_fee_club_member + "', available_slots='" + avaible_slots + "'" + "Where id= '" + id + "'";

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
