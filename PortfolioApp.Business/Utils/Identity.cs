using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PortfolioApp.Business.Interfaces;
using PortfolioApp.Entities.Concrete;

namespace PortfolioApp.Business.Utils
{
    public class Identity : Controller, IIdentityService
    {
        public int Id { get; set; }

        IUserService _userService;

        public Identity(IUserService userService)
        {
            _userService = userService;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var user = _userService.FindByName(User.Identity.Name);

            if (user != null)
            {
                Id = user.Id;
            }

            base.OnActionExecuted(context);
        }

        public User IdentityUser(string name)
        {
            var user = _userService.FindByName(name);
            return user;
        }
    }
}
