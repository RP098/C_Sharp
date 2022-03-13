using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Michelin_Garda_2021
{
    class PobierzWyniki
    {
        public List<Wyniki> pokaz()
        {
            Logowanie_ login1 = new Logowanie_();
            login1.polaczenie();



            List<Wyniki> dane = new List<Wyniki>();
            MySqlCommand cmd = Logowanie_.conn.CreateCommand();
            string sql = "SELECT contests.id as 'contest_id'," +
                " contests.name as 'contest_name'," +
                " competitions.id as 'competition_id'," +
                " competitions.competition_name as 'competition_name'," +
                " participating_competitors.id as 'participating_competitor_id'," +
                " participating_competitors.name as 'participating_competitor_name'," +
                "clubs.id as 'club_id'," +
                " clubs.name as 'club_name' ," +
                " results.place," +
                " results.inside," +
                " results.comments," +
                "results.result,"    +
                "results.id"    +
                " FROM results JOIN participating_competitors ON participating_competitors.id = results.participating_competitor_id JOIN contests ON contests.id= participating_competitors.contest_id  JOIN clubs ON participating_competitors.club_id = clubs.id JOIN competitions ON competitions.id = results.competition_id;";
            cmd = new MySqlCommand(sql, Logowanie_.conn);

            MySqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                dane.Add(new Wyniki()
                {
                    contests_id = rdr.GetInt64(0),
                    contests_name = rdr.GetString(1),
                    competition__id = rdr.GetInt64(2),
                    competition_name = rdr.GetString(3),
                    participan_competitor_id= rdr.GetInt64(4),
                    participan_competitor_name = rdr.GetString(5),
                    club_id = rdr.GetInt64(6),
                    club_name = rdr.GetString(7),
                    place = rdr.GetString(8),
                    inside = rdr.GetInt32(9),
                    comments = rdr.GetString(10),
                   result = rdr.GetString(11),
                   result_id= rdr.GetInt64(12)
                  
                });
                
            }


            Logowanie_.conn.Close();



            return dane;
        }



         

    }
}
