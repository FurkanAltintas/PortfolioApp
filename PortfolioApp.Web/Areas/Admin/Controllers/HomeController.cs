using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize] // Giriş yapması gerekiyor
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
