using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using iTextSharp;
namespace Michelin_Garda_2021
{
    class PobierzListeUzytkownikow
    {


        public List<Uzytkownik> pokazUzytkownikow()
        {
            Logowanie_ login1 = new Logowanie_();
            login1.polaczenie();

            bool czy = true;

            List<Uzytkownik> dane = new List<Uzytkownik>();
            MySqlCommand cmd = Logowanie_.conn.CreateCommand();
            string sql = "SELECT id,name,email,password FROM users";
            cmd = new MySqlCommand(sql, Logowanie_.conn);

            MySqlDataReader rdr = cmd.ExecuteReader();

           
            while (rdr.Read())
            {
               dane.Add(new Uzytkownik() { id = rdr.GetInt32(0),   name = rdr.GetString(1), email= rdr.GetString(2), password= rdr.GetString(3) });
              
            }

            
            Logowanie_.conn.Close();

             

            return dane;
        }

      


    }
}
