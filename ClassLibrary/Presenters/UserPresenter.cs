using ClassLibrary.Model_Views;
using ClassLibrary.Models;
using ClassLibrary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Presenters
{
   public class UserPresenter
    {
        private IUsersView views_;
        private IUsersModel model_;

        public UserPresenter (IUsersModel model, IUsersView views)
        {
            model_ = model;
            views_ = views;

            List<User> users_ = model_.Load();
            views_.ShowUsers(users_);
            
            
        }

    }
}
