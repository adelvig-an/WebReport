using BussinesLayer.Interface;
using DbLayer;
using Model;

namespace BussinesLayer.Repository
{
    public class ContractRepository : IRepository<Contract>
    {
        private ApplicationContext _context;

        public ContractRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Contract> GetAll()
        {
            return _context.Set<Contract>().ToList();
        }

        public Contract GetById(int id)
        {
            return _context.Contracts.First(x => x.Id == id);
        }

        public void SaveUpdate(Contract item)
        {
            if (item != null)
                if (item.Id != 0)
                    _context.Contracts.Update(item);
                else
                    _context.Contracts.Add(item);
            _context.SaveChanges();
        }


        public void Delete(Contract item)
        {
            _context.Contracts.Remove(item);
            _context.SaveChanges();
        }
    }
}
