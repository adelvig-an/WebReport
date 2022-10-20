using BussinesLayer.Interface;
using DbLayer;
using Microsoft.EntityFrameworkCore;
using Model;

namespace BussinesLayer.Repository
{
    public class UserRepository : IUserRepository
    {
        private ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAllUsers() 
        { 
            return _context.Set<User>().ToList();
        }

        public User GetUserById(int userId)
        {
            return _context.Users.First(x => x.Id == userId);
        }

        public void SaveUser(User user)
        {
            if (user != null)
                _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}
