using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Business.Interfaces;
using PortfolioApp.Entities.Concrete;

namespace PortfolioApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericService<Skill> _skillService;

        public HomeController(IGenericService<Skill> skillService)
        {
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            var skills = _skillService.GetAll();
            return View(skills);
        }
    }
}
