using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Michelin_Garda_2021
{
    class readKonkurencjaWZawodach
    {
        public List<KonkurencjeWZawodach> pokaz()
        {
            Login login1 = new Login();
            login1.polaczenie();



            List<KonkurencjeWZawodach> dane = new List<KonkurencjeWZawodach>();
            MySqlCommand cmd = Login.conn.CreateCommand();
            string sql = "SELECT included_competitions.id, contests.name, competitions.competition_name FROM included_competitions JOIN contests ON contests.id = included_competitions.contest_id JOIN competitions ON competitions.id = included_competitions.competition_id";
            cmd = new MySqlCommand(sql, Login.conn);

            MySqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                dane.Add(new KonkurencjeWZawodach()
                {
                    id = rdr.GetInt32(0),
                    contest_name = rdr.GetString(1),
                    competition_name = rdr.GetString(2),
                 
                });

            }


            Login.conn.Close();



            return dane;
        }
    }
}
