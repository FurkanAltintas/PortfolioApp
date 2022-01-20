using PortfolioApp.Business.Interfaces;
using PortfolioApp.DataAccess.Interfaces;
using PortfolioApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.Concrete
{
    public class UserManager : GenericManager<User>, IUserService
    {
        private readonly IGenericRepository<User> _genericRepository;
        private readonly IUserRepository _userRepository;

        public UserManager(IGenericRepository<User> genericRepository, IUserRepository userRepository) : base(genericRepository)
        {
            _genericRepository = genericRepository;
            _userRepository = userRepository;
        }

        public bool CheckUser(string userName, string password)
        {
            return _userRepository.CheckUser(userName, password);
        }

        public User FindByName(string userName)
        {
            return _userRepository.FindByName(userName);
        }

        public User GetUser()
        {
            return _userRepository.GetUser(); 
        }
    }
}
