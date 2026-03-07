using Module4.Interfaces;
using Module4.Models;
using Module4.Repositories;
namespace Module4.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepositories _userRepositories;

        public UserService(UserRepositories userRepositories)
        {
            _userRepositories = userRepositories;
        }

        public void AddUser(User user)
        {
            _userRepositories.AddUser(user);
        }

        public List<User> GetAllUsers()
        {
            return _userRepositories.GetAllUsers();
        }
    }
}