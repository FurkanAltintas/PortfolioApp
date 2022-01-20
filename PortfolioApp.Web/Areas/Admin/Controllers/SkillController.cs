using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Business.Interfaces;
using PortfolioApp.DTO.DTOs.SkillDtos;
using PortfolioApp.Entities.Concrete;
using PortfolioApp.Web.Areas.Admin.Models;
using System.Collections.Generic;

namespace PortfolioApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SkillController : Controller
    {
        private readonly IGenericService<Skill> _skillGenericService;
        private readonly IMapper _mapper;

        public SkillController(IGenericService<Skill> skillGenericService, IMapper mapper)
        {
            _skillGenericService = skillGenericService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var model = new SkillViewModel
            {
                Skills = _mapper.Map<List<SkillListDto>>(_skillGenericService.GetAll())
            };

            return View(model);
        }

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(SkillAddDto skillAddDto)
        {
            if (ModelState.IsValid)
            {
                var skill = _mapper.Map<Skill>(skillAddDto);
                _skillGenericService.Insert(skill);
                return RedirectToAction("Index");
            }

            return View(skillAddDto);
        }

        public IActionResult Edit(int id)
        {
            return View(_mapper.Map<SkillUpdateDto>(_skillGenericService.GetById(id)));
        }

        [HttpPost]
        public IActionResult Edit(SkillUpdateDto skillUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var skill = _mapper.Map<Skill>(skillUpdateDto);
                _skillGenericService.Update(skill);
                return RedirectToAction("Index");
            }

            return View(skillUpdateDto);
        }

        public IActionResult Delete(int id)
        {
            _skillGenericService.Delete(new Skill { Id = id });
            return RedirectToAction("Index");
        }
    }
}
