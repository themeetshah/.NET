using Module2.Models;
namespace Module2.Services
{
    public class UserService
    {
        private readonly List<User> _users = new List<User>();

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }
    }
}