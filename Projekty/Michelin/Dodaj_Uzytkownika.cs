using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Michelin_Garda_2021
{
    class Dodaj_Uzytkownika
    {
      
        public bool dodaj(string email, string haslo,string nazwa)
        {
            try
            {
                Logowanie_ login1 = new Logowanie_();
                login1.polaczenie();

                bool czy = true;

                List<string> loginy = new List<string>();
                MySqlCommand cmd = Logowanie_.conn.CreateCommand();
                string sql = "SELECT * FROM users";
                cmd = new MySqlCommand(sql, Logowanie_.conn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    loginy.Add(rdr.GetString(2).ToString());
                }

                foreach (var d in loginy)
                {
                    if (d.CompareTo(email) == 0)
                        czy = false;

                }
                Logowanie_.conn.Close();

                if (czy)
                {
                    string MyConnection2 = "SERVER = localhost; PORT = 3306; DATABASE = towarzysze; UID = " + Logowanie_.user + "; " + "PASSWORD = " + Logowanie_.password + "; ";


                    string Query = "INSERT INTO users(name,email,password) values('" + nazwa + "','" + email + "','" + haslo + "' )";

                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();

                    MyConn2.Close();
                }
                else
                {
                    return false;

                }

            }
            catch
            {
                return false;
            }
            return true;
        }
     
    }
}
