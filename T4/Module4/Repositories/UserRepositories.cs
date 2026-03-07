using Module4.Models;
namespace Module4.Repositories
{
    public class UserRepositories
    {
        private readonly List<User> _users = new();

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }
    }
}