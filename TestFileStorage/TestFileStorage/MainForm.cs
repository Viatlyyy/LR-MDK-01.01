using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestFileStorage
{
    public partial class LoginForm: Form
    {
        private FileUserStorage authorization_ = new FileUserStorage();
        private List<string> logins_ = new List<string>();
        public LoginForm()
        {
            InitializeComponent();
            List<User> allUsers = authorization_.Load();

            foreach(User u in allUsers)
            {
                logins_.Add(u.Login);
            }

            LoginComboBox.DataSource = logins_;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            List<User> identification = authorization_.Load();

            string login = LoginComboBox.Text;
            string password = PasswordTextBox.Text;

            if (authorization_.Authorize(login,password))
            {
                MessageBox.Show("Вы в системе");
            }

            else
            {
                MessageBox.Show("Вход не удался");
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            SighUpForm sighUp = new SighUpForm();
            sighUp.Show();
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            logins_.Clear();
            List<User> allUsers = authorization_.Load();

            foreach (User u in allUsers)
            {
                logins_.Add(u.Login);
            }
            LoginComboBox.DataSource = null;
            LoginComboBox.DataSource = logins_;
        }
    }
}
