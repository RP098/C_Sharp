using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Michelin_Garda_2021
{
    class updateKonkurencjaInBaza
    {
        public bool ZmienDane(int id, string name, string competition_code, string content, konkurencje.used_weapon used, int avaible_slots,decimal own_weapon_tariff_a, decimal own_weapon_tariff_b , decimal club_weapon_tariff_a, decimal club_weapon_tariff_b)
        {
            try
            {
                string MyConnection2 = "SERVER = localhost; PORT = 3306; DATABASE = towarzysze; UID = " + Login.user + "; " + "PASSWORD = " + Login.password + "; ";
                /*
                UPDATE Customers
                SET ContactName = 'Alfred Schmidt', City= 'Frankfurt'
                WHERE CustomerID = 1; 

                 */

                string Query = "UPDATE competitions " +
                    "SET competition_name = '" + name + "', competition_content='" + content + "', competition_code='" + competition_code + "', used_weapon='" + used + "',  competition_available_slots='" + avaible_slots + "',  own_weapon_tariff_a='" + own_weapon_tariff_a + "',  own_weapon_tariff_b='" + own_weapon_tariff_b + "',  club_weapon_tariff_a='" + club_weapon_tariff_a + "',  club_weapon_tariff_b='" + club_weapon_tariff_b + "'" + "Where id= '" + id + "'";

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

//,own_weapon_tariff_a,  own_weapon_tariff_b , club_weapon_tariff_a, club_weapon_tariff_b  competition_available_slots