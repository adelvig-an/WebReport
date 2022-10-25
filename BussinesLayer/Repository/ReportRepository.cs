using BussinesLayer.Interface;
using DbLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Repository
{
    public class ReportRepository : IRepository<Report>
    {
        private readonly ApplicationContext _context;

        public ReportRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Report> GetAll()
        {
            return _context.Set<Report>().ToList();
        }

        public Report GetById(int id)
        {
            return _context.Reports.First(x => x.Id == id);
        }

        public void SaveUpdate(Report item)
        {
            if (item != null)
                if (item.Id != 0)
                    _context.Reports.Update(item);
                else
                    _context.Reports.Add(item);
            _context.SaveChanges();
        }


        public void Delete(Report item)
        {
            _context.Reports.Remove(item);
            _context.SaveChanges();
        }
    }
}
