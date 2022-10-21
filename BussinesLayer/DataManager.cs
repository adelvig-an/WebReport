using BussinesLayer.Interface;

namespace BussinesLayer
{
    public class DataManager
    {
        private IUserRepository _userRepository;

        public DataManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IUserRepository User { get { return _userRepository; } }
    }
}
