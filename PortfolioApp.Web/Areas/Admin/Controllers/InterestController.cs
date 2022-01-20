using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Business.Interfaces;
using PortfolioApp.DTO.DTOs.InterestDtos;
using PortfolioApp.Entities.Concrete;
using PortfolioApp.Web.Areas.Admin.Models;
using System.Collections.Generic;

namespace PortfolioApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InterestController : Controller
    {
        private readonly IGenericService<Interest> _interestGenericService;
        private readonly IMapper _mapper;

        public InterestController(IGenericService<Interest> interestGenericService, IMapper mapper)
        {
            _interestGenericService = interestGenericService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var model = new InterestViewModel
            {
                Interests = _mapper.Map<List<InterestListDto>>(_interestGenericService.GetAll())
            };

            return View(model);
        }

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(InterestAddDto interestAddDto)
        {
            if (ModelState.IsValid)
            {
                var interest = _mapper.Map<Interest>(interestAddDto);
                _interestGenericService.Insert(interest);
                return RedirectToAction("Index");
            }

            return View(interestAddDto);
        }

        public IActionResult Edit(int id)
        {
            if (id > 0)
            {
                var interest = _interestGenericService.GetById(id);

                if (interest != null)
                {
                    return View(_mapper.Map<InterestUpdateDto>(interest));
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(InterestUpdateDto interestUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var interest = _mapper.Map<Interest>(interestUpdateDto);
                _interestGenericService.Update(interest);
            }

            return View(interestUpdateDto);
        }

        public IActionResult Delete(int id)
        {
            _interestGenericService.Delete(new Interest { Id = id });

            return RedirectToAction("Index");
        }
    }
}