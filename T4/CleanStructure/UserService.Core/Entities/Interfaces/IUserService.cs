using UserService.Core.Entities.Models;

namespace UserService.Core.Entities.Interfaces
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        void AddUser(User user);
    }
}