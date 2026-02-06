using System.Collections.Generic;
using System.IO;

namespace TestFileStorage
{
    public class FileUserStorage : IUserInterface
    {
        public bool Authorize(string log, string pass)
        {
            List<User> identification = Load();

            User user = new User(log, pass);

            return Contains(identification, user);
        }

        public List<User> Load()
        {
            List<User> allUsers = new List<User>();
            string path = @".\info.txt";
            StreamReader sr = new StreamReader(path);

            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] lines = line.Split('-');
                allUsers.Add(new User(lines[0], lines[1]));
            }

            sr.Close();

            return allUsers;
        }

        public bool CheckUser(string log)
        {
            List<User> identification = Load();

            foreach(User u in identification)
            {
                if(u.Login == log)
                {
                    return true;
                }
            }

            return false;
        }

        private bool Contains(List<User> users, User user)
        {
            foreach (User u in users)
            {
                if (user.Login == u.Login && u.Password == user.Password)
                {
                    return true;
                }
            }

            return false;
        }

        public bool Registration(User u)
        {
            string path = @".\info.txt";
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(u.Login + "-" + u.Password);
            sw.Close();
            return true;
        }
    }
}
