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
    public class SocialMediaIconManager : GenericManager<SocialMediaIcon>, ISocialMediaIconService
    {
        private readonly IGenericRepository<SocialMediaIcon> _socialMediaIconGenericRepository;
        private readonly ISocialMediaIconRepository _socialMediaIconRepository;
        public SocialMediaIconManager(IGenericRepository<SocialMediaIcon> socialMediaIconGenericRepository, ISocialMediaIconRepository socialMediaIconRepository) : base(socialMediaIconGenericRepository)
        {
            _socialMediaIconGenericRepository = socialMediaIconGenericRepository;
            _socialMediaIconRepository = socialMediaIconRepository;
        }

        public List<SocialMediaIcon> GetByUserId(int userId)
        {
            return _socialMediaIconRepository.GetByUserId(userId);
        }
    }
}
