using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using iTextSharp;
namespace Michelin_Garda_2021
{
    class readUser
    {


        public List<users> pokazUzytkownikow()
        {
            Login login1 = new Login();
            login1.polaczenie();

            bool czy = true;

            List<users> dane = new List<users>();
            MySqlCommand cmd = Login.conn.CreateCommand();
            string sql = "SELECT id,name,email,password FROM users";
            cmd = new MySqlCommand(sql, Login.conn);

            MySqlDataReader rdr = cmd.ExecuteReader();

           
            while (rdr.Read())
            {
               dane.Add(new users() { id = rdr.GetInt32(0),   name = rdr.GetString(1), email= rdr.GetString(2), password= rdr.GetString(3) });
              
            }

            
            Login.conn.Close();

             

            return dane;
        }

      


    }
}
