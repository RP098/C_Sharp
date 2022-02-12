﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Michelin_Garda_2021
{
    class readZawody
    {
        public List<Zawody> pokazZawody()
        {
            Login login1 = new Login();
            login1.polaczenie();

          

            List<Zawody> dane = new List<Zawody>();
            MySqlCommand cmd = Login.conn.CreateCommand();
            string sql = "SELECT id,name,content,schedule,Entry_fee_outside_the_club,Entry_fee_club_member,available_slots From contests";
            cmd = new MySqlCommand(sql, Login.conn);

            MySqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                dane.Add(new Zawody() { id = rdr.GetInt32(0), name = rdr.GetString(1), content = rdr.GetString(2), schedule = rdr.GetString(3)
                ,
                    Entry_fee_outside_the_club = rdr.GetDecimal(4),
                    Entry_fee_club_member = rdr.GetDecimal(5), available_slots = rdr.GetInt32(6) });

            }


            Login.conn.Close();



            return dane;
        }

    }
}
