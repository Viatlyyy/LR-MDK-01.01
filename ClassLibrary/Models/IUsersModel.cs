using ClassLibrary.Model_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
  public interface IUsersModel
    {
        List<User> Load();
        bool Register(User user);
    }
}
