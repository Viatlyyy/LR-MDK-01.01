using System;
using System.Windows.Forms;

namespace TestFileStorage
{
    public partial class SighUpForm: Form
    {
        private FileUserStorage registration_ = new FileUserStorage();
        public SighUpForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            User user = new User(login, password);

            if (login == string.Empty)
            {
                MessageBox.Show("Вы не ввели логин");
                return;
            }

            if (password == string.Empty)
            {
                MessageBox.Show("Вы не ввели пароль");
                return;
            }

            if (registration_.CheckUser(login))
            {
                MessageBox.Show("Такой пользователь уже существует");
            }

            else
            {
                if (registration_.Registration(user))
                {
                    MessageBox.Show("Вы успешно зарегистрировались");
                }
            }
        }
    }
}
