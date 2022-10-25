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
    public class EvaluationTaskRepository : IRepository<EvaluationTask>
    {
        private readonly ApplicationContext _context;
        public EvaluationTaskRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<EvaluationTask> GetAll()
        {
            return _context.Set<EvaluationTask>().ToList();
        }
        public EvaluationTask GetById(int id)
        {
            return _context.EvaluationTasks.First(t => t.Id == id);
        }

        public void SaveUpdate(EvaluationTask item)
        {
            if (item != null)
                if (item.Id != 0)
                    _context.EvaluationTasks.Update(item);
                else
                    _context.EvaluationTasks.Add(item);
            _context.SaveChanges();
        }

        public void Delete(EvaluationTask item)
        {
            _context.EvaluationTasks.Remove(item);
            _context.SaveChanges();
        }
    }
}
