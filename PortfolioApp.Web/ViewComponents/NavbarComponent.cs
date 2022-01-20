using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.Web.ViewComponents
{
    public class NavbarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
