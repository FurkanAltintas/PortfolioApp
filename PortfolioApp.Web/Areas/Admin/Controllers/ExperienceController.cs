using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Business.Interfaces;
using PortfolioApp.DTO.DTOs.ExperienceDtos;
using PortfolioApp.Web.Areas.Admin.Models;

namespace PortfolioApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExperienceController : Controller
    {
        IExperienceService _experienceService;

        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public IActionResult Index()
        {
            var model = new ExpeirenceListViewModel
            {
                Expeirences = _experienceService.GetAll()
            };

            return View(model);
        }

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(ExperienceAddDto experienceAddDto)
        {
            if (ModelState.IsValid)
            {
                _experienceService.Insert(experienceAddDto);
                return RedirectToAction("Index");
            }

            return View("Index");
        }

        public IActionResult Edit(int id)
        {
            if (id > 0)
            {
                return View(_experienceService.GetById(id));
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(ExperienceUpdateDto experienceUpdateDto)
        {
            if (ModelState.IsValid)
            {
                _experienceService.Update(experienceUpdateDto);
                return RedirectToAction("Index");
            }

            return View(experienceUpdateDto);
        }

        public IActionResult Delete(int id)
        {
            if (id > 0)
            {
                _experienceService.Delete(id);
            }

            return RedirectToAction("Index");
        }
    }
}
