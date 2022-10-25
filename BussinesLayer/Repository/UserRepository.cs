using BussinesLayer.Interface;
using DbLayer;
using Microsoft.EntityFrameworkCore;
using Model;

namespace BussinesLayer.Repository
{
    public class UserRepository : IRepository<User>
    {
        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll() 
        { 
            return _context.Set<User>().ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.First(x => x.Id == id);
        }

        public void SaveUpdate(User item)
        {
            if (item != null)
                if (item.Id != 0)
                    _context.Users.Update(item);
                else
                    _context.Users.Add(item);
            _context.SaveChanges();
        }


        public void Delete(User item)
        {
            _context.Users.Remove(item);
            _context.SaveChanges();
        }
    }
}
