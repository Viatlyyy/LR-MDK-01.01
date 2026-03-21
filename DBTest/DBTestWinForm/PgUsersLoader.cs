using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTestWinForm
{
    public class PgUsersLoader
    {
        private BindingList<User> allUsers_ = new BindingList<User>();
        private const string connectSetting = "Host=192.168.1.48;Username=st50-4;Password=504;Database=MDK01.01_Kuvaldaev";
        public BindingList<User> Load() 
        {
            try
            {

                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT login, password, age, name, last_name From myusers";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        Login = reader.GetString(0),
                        Password = reader.GetString(1),
                        Age = reader.GetInt32(2),
                        Name = reader.GetString(3),
                        LastName = reader.GetString(4)
                    };
                    allUsers_.Add(user);
                }
                return allUsers_;
            }
            catch(NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return null;
            }
        } 
        
        public bool DeleteSelectedUser(string Login)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "DELETE FROM myusers Where login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", Login);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                    
                }
                for (int i = 0; i < allUsers_.Count; i++)
                {
                    if (allUsers_[i].Login == Login)
                    {
                        allUsers_.RemoveAt(i);
                        i--;
                    }
                }
                return result;
            }
            catch(NpgsqlException exception) 
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }

        public bool ClearUsers()
        {
           
            bool result = false;
            var con = new NpgsqlConnection(connectSetting);
            var sql = "DELETE FROM myusers";
            con.Open();
            var cmd = new NpgsqlCommand(sql, con);
            int execute = cmd.ExecuteNonQuery();
            if (execute > 0)
            {
                result = true;
            }
            allUsers_.Clear();
            return result;
        
        }

        public bool AddUser()
        {
            bool result = false;
            var con = new NpgsqlConnection(connectSetting);
            var sql = "INSERT INTO myusers (login, password, age, name, lastname) VALUES(login, password, age, name, lastname)";
            con.Open();
            var cmd = new NpgsqlCommand(sql, con);
            int execute = cmd.ExecuteNonQuery();
            if (execute > 0)
            {
                result = true;
            }
        }
    }
}
