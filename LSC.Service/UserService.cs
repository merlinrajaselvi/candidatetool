using LSC.Core;
using System;

namespace LSC.Service
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;   

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }


    }
}
