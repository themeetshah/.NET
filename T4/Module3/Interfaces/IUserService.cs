using Module3.Models;
namespace Module3.Interfaces
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        void AddUser(User user);
    }
}