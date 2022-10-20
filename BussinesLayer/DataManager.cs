using BussinesLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
