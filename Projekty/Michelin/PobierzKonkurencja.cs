using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Michelin_Garda_2021
{
    class PobierzKonkurencja
    {
        public List<Konkurencje> pokaz()
        {
            Logowanie_ login1 = new Logowanie_();
            login1.polaczenie();



            List< Konkurencje> dane = new List<Konkurencje>();
            MySqlCommand cmd = Logowanie_.conn.CreateCommand();
            string sql = "SELECT  id,  competition_name,  competition_code,  competition_content, used_weapon ,own_weapon_tariff_a,  own_weapon_tariff_b , club_weapon_tariff_a, club_weapon_tariff_b,  competition_available_slots From competitions";
            cmd = new MySqlCommand(sql, Logowanie_.conn);

            MySqlDataReader rdr = cmd.ExecuteReader();
           

            while (rdr.Read())
            {
                dane.Add(new Konkurencje()
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


            Logowanie_.conn.Close();



            return dane;
        }
    }
}
