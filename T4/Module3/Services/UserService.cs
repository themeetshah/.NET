using Module3.Models;
namespace Module3.Services
{
    public class UserService : Module3.Interfaces.IUserService
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