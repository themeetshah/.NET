using UserService.Core.Entities.Models;
namespace UserService.Infrastructure.Repositories
{
    public class UserRepository
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