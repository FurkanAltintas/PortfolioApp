using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Business.Interfaces;
using PortfolioApp.DTO.DTOs.CertificationDtos;
using PortfolioApp.Entities.Concrete;
using System.Collections.Generic;

namespace PortfolioApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CertificationController : Controller
    {
        private readonly IGenericService<Certification> _certificationGenericService;
        private readonly IMapper _mapper;

        public CertificationController(IGenericService<Certification> certificationGenericService, IMapper mapper)
        {
            _certificationGenericService = certificationGenericService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var certifications = _mapper.Map<List<CertificationListDto>>(_certificationGenericService.GetAll());
            return View(certifications);
        }

        public IActionResult  Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(CertificationAddDto certificationAddDto)
        {
            if (ModelState.IsValid)
            {
                var certification = _mapper.Map<Certification>(certificationAddDto);
                _certificationGenericService.Insert(certification);
                return RedirectToAction("Index");
            }

            return View(certificationAddDto);
        }

        public IActionResult Edit(int id)
        {
            if (id > 0)
            {
                var model = _mapper.Map<CertificationUpdateDto>(_certificationGenericService.GetById(id));
                return View(model);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(CertificationUpdateDto certificationUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var certification = _mapper.Map<Certification>(certificationUpdateDto);
                _certificationGenericService.Update(certification);
                return RedirectToAction("Index");
            }

            return View(certificationUpdateDto);
        }

        public IActionResult Delete(int id)
        {
            if (id > 0)
            {
                _certificationGenericService.Delete(new Certification { Id = id });
            }
            return RedirectToAction("Index");
        }
    }
}
