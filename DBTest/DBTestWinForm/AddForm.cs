using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTestWinForm
{
    public partial class AddForm: Form
    {
        private PgUsersLoader loader_;
        
        public AddForm(PgUsersLoader loader)
        {
            InitializeComponent();
            loader_ = loader;
        }



        public void AddUser()
        {
            loader_.AddUser(new User
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                Name = NameTextBox.Text,
                Age = (int)AgeNumericUpDown.Value
            }
            );
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            AddUser();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
