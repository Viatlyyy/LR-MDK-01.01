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


namespace DBTestWinForm
{
    public partial class MainFrom: Form
    {
        PgUsersLoader loader_ = new PgUsersLoader();

        public MainFrom()
        {                                              
            InitializeComponent();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            BindingList<User> users = loader_.Load();
            dataGridView.DataSource = users;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];
            User user = row.DataBoundItem as User;
            loader_.DeleteSelectedUser(user.Login);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите очистить всю таблицу?", "Внимание!", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                loader_.ClearUser();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            AddForm additionForm = new AddForm(loader_);
            additionForm.Show();
        }
    }
}
