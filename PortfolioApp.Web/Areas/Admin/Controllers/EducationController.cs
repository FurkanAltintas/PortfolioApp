using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Business.Interfaces;
using PortfolioApp.DTO.DTOs.EducationDtos;
using PortfolioApp.Entities.Concrete;
using PortfolioApp.Web.Areas.Admin.Models;
using System.Collections.Generic;

namespace PortfolioApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EducationController : Controller
    {
        IGenericService<Education> _educationGenericService;
        IMapper _mapper;

        public EducationController(IGenericService<Education> educationGenericService, IMapper mapper)
        {
            _educationGenericService = educationGenericService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var model = new EducationListViewModel
            {
                Educations = _mapper.Map<List<EducationListDto>>(_educationGenericService.GetAll())
            };

            return View(model);
        }

        public IActionResult  Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(EducationAddDto educationAddDto)
        {
            if (ModelState.IsValid)
            {
                var education = _mapper.Map<Education>(educationAddDto);
                _educationGenericService.Insert(education);
                return RedirectToAction("Index");
            }
            return View(educationAddDto);
        }

        public IActionResult Edit(int id)
        {
            if (id > 0)
            {
                return View(_mapper.Map<EducationUpdateDto>(_educationGenericService.GetById(id)));
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(EducationUpdateDto educationUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var education = _mapper.Map<Education>(educationUpdateDto);
                _educationGenericService.Update(education);
                return RedirectToAction("Index");
            }

            return View(educationUpdateDto);
        }

        public IActionResult Delete(int id)
        {
            if (id > 0)
            {
                _educationGenericService.Delete(new Education { Id = id });
            }

            return RedirectToAction("Index");
        }
    }
}
