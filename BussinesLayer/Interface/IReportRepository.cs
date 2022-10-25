using Model;

namespace BussinesLayer.Interface
{
    public interface IReportRepository
    {
        IEnumerable<Report> GetAllReports();
        public Report GetReportById(int reportId);
        void SaveUpdateReport(Report report);
        void DeleteReport(Report report);
    }
}
