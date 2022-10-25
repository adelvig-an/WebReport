using BussinesLayer.Interface;

namespace BussinesLayer
{
    public class DataManager
    {
        private IUserRepository _userRepository;
        private IReportRepository _reportRepository;

        public DataManager(IUserRepository userRepository, IReportRepository reportRepository)
        {
            _userRepository = userRepository;
            _reportRepository = reportRepository;
        }

        public IUserRepository User { get { return _userRepository; } }
        public IReportRepository Report { get { return _reportRepository; } }
    }
}
