using System.Collections.Generic;

namespace TestFileStorage
{
    public interface IUserInterface
    {
        List<User> Load();
        string Registration(User u);
        bool CheckExistsUser(string login);
    }
    
}
