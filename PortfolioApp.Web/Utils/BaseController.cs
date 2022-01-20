using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PortfolioApp.Business.Interfaces;

namespace PortfolioApp.Web.Utils
{
    public class BaseController :  Controller
    {
        public int Id { get; set; }

        private readonly IUserService _userService;

        public BaseController(IUserService userService)
        {
            _userService = userService;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var user = _userService.FindByName(User.Identity.Name);

            Id = user.Id;

            base.OnActionExecuted(context);
        }
    }
}
