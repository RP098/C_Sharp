using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Michelin_Garda_2021
{
    class addKonkurencja
    {
        public bool dodaj(string name, string competition_code, string content, konkurencje.used_weapon used  , int avaible_slots,decimal own_weapon_tariff_a, decimal own_weapon_tariff_b ,decimal club_weapon_tariff_a,decimal club_weapon_tariff_b)
        {
            try
           {

                string MyConnection2 = "SERVER = localhost; PORT = 3306; DATABASE = towarzysze; UID = " + Login.user + "; " + "PASSWORD = " + Login.password + "; ";

                string Query = "INSERT INTO competitions(competition_name,competition_content,competition_code,used_weapon,competition_available_slots,own_weapon_tariff_a,  own_weapon_tariff_b , club_weapon_tariff_a, club_weapon_tariff_b) values" +
                "('" + name + "','" + content + "','" + competition_code + "' ,'" + used + "','" + avaible_slots + "','" + own_weapon_tariff_a + "','" + own_weapon_tariff_b + "','" + club_weapon_tariff_a + "','" + club_weapon_tariff_b+"')";

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
/*
 own_weapon_tariff_a
own_weapon_tariff_b               
club_weapon_tariff_a       
club_weapon_tariff_b

 ,own_weapon_tariff_a,  own_weapon_tariff_b , club_weapon_tariff_a, club_weapon_tariff_b
*/