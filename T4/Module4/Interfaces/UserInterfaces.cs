using Module4.Models;
namespace Module4.Interfaces
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        void AddUser(User user);
    }
}