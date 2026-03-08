using UserService.Core.Entities.Interfaces;
using UserService.Core.Entities.Models;
using UserService.Infrastructure.Repositories;
namespace UserService.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(User user)
        {
            _userRepository.AddUser(user);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
    }
}