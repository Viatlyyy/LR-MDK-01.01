using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public class PostgresUsersLoader
    {
        public List<User> Load()
        {
            
            var cs = "Host=192.168.1.48;Username=st50-4;Password=504;Database=proptest";

            var con = new NpgsqlConnection(cs);
            con.Open();


            string sql = "SELECT login, password FROM myusers";
            var cmd = new NpgsqlCommand(sql, con);

            var reader = cmd.ExecuteReader();
            List<User> allUsers = new List<User>();
            while (reader.Read())
            {
                allUsers.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));

            }

            MessageBox.Show($"Login: {string.Join(", ", allUsers)}");


            con.Close();

            return allUsers;
        }
    }
}

        
    

