using Model;

namespace BussinesLayer.Interface
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        public User GetUserById(int userId);
        void SaveUpdateUser (User user);
        void DeleteUser (User user);

    }
}
