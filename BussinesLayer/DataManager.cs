using BussinesLayer.Interface;
using Model;

namespace BussinesLayer
{
    public class DataManager
    {
        private IRepository<User> _userRepository;
        private IRepository<Report> _reportRepository;
        private IRepository<Contract> _contractRepository;
        private IRepository<EvaluationTask> _evaluationTaskRepository;

        public DataManager(IRepository<User> userRepository, 
            IRepository<Report> reportRepository,
            IRepository<Contract> contractRepository,
            IRepository<EvaluationTask> evaluationTaskRepository)
        {
            _userRepository = userRepository;
            _reportRepository = reportRepository;
            _contractRepository = contractRepository;
            _evaluationTaskRepository = evaluationTaskRepository;
        }

        public IRepository<User> User { get { return _userRepository; } }
        public IRepository<Report> Report { get { return _reportRepository; } }
        public IRepository<Contract> Contact { get { return _contractRepository; } }
        public IRepository<EvaluationTask> EvaluationTask { get { return _evaluationTaskRepository; } }
    }
}
