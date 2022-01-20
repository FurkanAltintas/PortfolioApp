using PortfolioApp.Entities.Concrete;

namespace PortfolioApp.Business.Utils
{
    public interface IIdentityService
    {
        public User IdentityUser(string name);
    }
}
