using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Michelin_Garda_2021
{
    class PobierzKonkurencjeWZawodach
    {
        public List<KonkurencjeWZawodach> pokaz()
        {
            Logowanie_ login1 = new Logowanie_();
            login1.polaczenie();



            List<KonkurencjeWZawodach> dane = new List<KonkurencjeWZawodach>();
            MySqlCommand cmd = Logowanie_.conn.CreateCommand();
            string sql = "SELECT included_competitions.id, contests.name, competitions.competition_name FROM included_competitions JOIN contests ON contests.id = included_competitions.contest_id JOIN competitions ON competitions.id = included_competitions.competition_id";
            cmd = new MySqlCommand(sql, Logowanie_.conn);

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


            Logowanie_.conn.Close();



            return dane;
        }
    }
}
