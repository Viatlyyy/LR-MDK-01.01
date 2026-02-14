using ClassLibrary.Model_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Views
{
  public interface IUsersView
    {
       void ShowUsers(List <User> allUsers_);

        List<User> GetSelection();
    }
}
