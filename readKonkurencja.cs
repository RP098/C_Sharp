using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Michelin_Garda_2021
{
    class readKonkurencja
    {
        public List<konkurencje> pokaz()
        {
            Login login1 = new Login();
            login1.polaczenie();



            List< konkurencje> dane = new List<konkurencje>();
            MySqlCommand cmd = Login.conn.CreateCommand();
            string sql = "SELECT  id,  competition_name,  competition_code,  competition_content, used_weapon ,own_weapon_tariff_a,  own_weapon_tariff_b , club_weapon_tariff_a, club_weapon_tariff_b,  competition_available_slots From competitions";
            cmd = new MySqlCommand(sql, Login.conn);

            MySqlDataReader rdr = cmd.ExecuteReader();
           

            while (rdr.Read())
            {
                dane.Add(new konkurencje()
                {
                    id = rdr.GetInt32(0),
                    name = rdr.GetString(1),
                    competition_code = rdr.GetString(2),
                    content = rdr.GetString(3),
                    weapon = rdr.GetString(4),
                    available_slots = rdr.GetInt32(5),
                    own_weapon_tariff_a=Convert.ToDecimal(rdr[6].ToString()),
                    own_weapon_tariff_b= Convert.ToDecimal(rdr[7].ToString()),
                    club_weapon_tariff_a= Convert.ToDecimal(rdr[8].ToString()),
                    club_weapon_tariff_b= Convert.ToDecimal(rdr[9].ToString()),
                    
                }) ;
                
            }


            Login.conn.Close();



            return dane;
        }
    }
}
