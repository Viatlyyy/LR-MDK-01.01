using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace BD
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
            var cs = "Host=192.168.1.48;Username=st50-4;Password=504;Database=proptest";

            var con = new NpgsqlConnection(cs);
            con.Open();


            string sql = "SELECT login, password FROM myusers";
            var cmd = new NpgsqlCommand(sql, con);

            var reader = cmd.ExecuteReader();
            List<string> allLogin = new List<string>();
            while (reader.Read())
            {
                allLogin.Add(reader.GetString(0) + ":" + reader.GetString(1));

            
            }
            
            MessageBox.Show($"Login: {string.Join(", ", allLogin)}");
            
            
            con.Close();
        }
    }
}
