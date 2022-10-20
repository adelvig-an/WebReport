using Model;

namespace BussinesLayer.Interface
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        public User GetUserById(int userId);
        void SaveUser (User user);
        void DeleteUser (User user);

    }
}
