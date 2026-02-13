using ClassLibrary.Model_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class MemoryUsersModel : IUsersModel
    {
        private List<User> allUsers_ = new List<User>();

        public MemoryUsersModel()
        {
            allUsers_.Add(new User("denis123", "qwerty123", "Denis Tsetkov"));
            allUsers_.Add(new User("zaharProhorov2011", "qwerty456", "Zahar Tsetkov"));
            allUsers_.Add(new User("Arina2008", "qwerty123321", "Arina Chizikova"));
            allUsers_.Add(new User("OlgaSafonova2006", "qwerty123456", "Olga Safonova"));
            allUsers_.Add(new User("KrilowVitaly007", "qwerty3211234", "Vitaly Krilow"));
        }
        public List<User> Load()
        {
            return allUsers_;
        }
        public bool Register(User user)
        {
            int count = allUsers_.Count;
            allUsers_.Add(user);
            if (allUsers_.Count > count)
            {
                return true;
            }
                return false;
        }
    }
}


