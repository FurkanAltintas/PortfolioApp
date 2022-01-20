using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Business.Interfaces;

namespace PortfolioApp.Web.ViewComponents
{
    public class FooterComponent :  ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
