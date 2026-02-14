using ClassLibrary.Model_Views;
using ClassLibrary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelViewLib
{
    public class UsersTableVIew : DataGridView, IUsersView
    {
       
        public List<User> GetSelection()
        {
            List<User> result = new List<User>();
            foreach (var row in SelectedRows) 
            {

            }
        }
        
        
        
        public void ShowUsers(List<User> allUsers_)
        {
            DataSource = allUsers_;
        }
    }
}
