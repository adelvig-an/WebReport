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
    public class ReportRepository : IReportRepository
    {
        private ApplicationContext _context;

        public ReportRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Report> GetAllReports()
        {
            return _context.Set<Report>().ToList();
        }

        public Report GetReportById(int reportId)
        {
            return _context.Reports.First(x => x.Id == reportId);
        }

        public void SaveUpdateReport(Report report)
        {
            if (report != null)
                if (report.Id != 0)
                    _context.Reports.Update(report);
                else
                    _context.Reports.Add(report);
            _context.SaveChanges();
        }


        public void DeleteReport(Report report)
        {
            _context.Reports.Remove(report);
            _context.SaveChanges();
        }
    }
}
