using ClassLibrary.Models;
using ClassLibrary.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelViewLib
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
            UsersTableVIew userTable = new UsersTableVIew();
            Controls.Add(userTable);
            userTable.Dock = DockStyle.Top;

            UserPresenter userPresenter = new UserPresenter(new MemoryUsersModel(), userTable);
            
        }
    }
}
