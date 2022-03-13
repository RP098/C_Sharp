using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Michelin_Garda_2021
{
    class PobierzSedziow
    {
        public List<Sedziowie> pokaz()
        {
            Logowanie_ login1 = new Logowanie_();
            login1.polaczenie();



            List<Sedziowie> dane = new List<Sedziowie>();
            MySqlCommand cmd = Logowanie_.conn.CreateCommand();
            string sql = "SELECT judges.id, participating_competitors.name, contests.name, judges.judge_license " +
            " FROM judges JOIN participating_competitors ON participating_competitors.id= judges.id " +
            "JOIN contests ON contests.id= participating_competitors.contest_id";
            cmd = new MySqlCommand(sql, Logowanie_.conn);

            MySqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                dane.Add(new Sedziowie()
                {
                    id = rdr.GetInt32(0),
                    judge_name = rdr.GetString(1),
                    contest_name= rdr.GetString(2),
                    judge_license= rdr.GetString(3)

                }) ;

            }


            Logowanie_.conn.Close();



            return dane;
        }
    }
}
