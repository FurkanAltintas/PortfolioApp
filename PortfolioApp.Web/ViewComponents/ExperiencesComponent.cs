using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Business.Interfaces;

namespace PortfolioApp.Web.ViewComponents
{
    public class ExperiencesComponent : ViewComponent
    {
        private readonly IExperienceService _experienceService;

        public ExperiencesComponent(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_experienceService.GetAllOrderByDescending());
        }
    }
}
