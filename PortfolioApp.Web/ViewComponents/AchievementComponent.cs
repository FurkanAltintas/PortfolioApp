using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Business.Interfaces;
using PortfolioApp.DTO.DTOs.CertificationDtos;
using PortfolioApp.Entities.Concrete;
using System.Collections.Generic;

namespace PortfolioApp.Web.ViewComponents
{
    public class AchievementComponent :  ViewComponent
    {
        private readonly ICertificationService _certificationService;
        private readonly IMapper _mapper;

        public AchievementComponent(ICertificationService certificationService, IMapper mapper)
        {
            _certificationService = certificationService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var certification = _certificationService.GetAllDate();
            // _mapper.Map<List<CertificationListDto>>(_certificationGenericService.GetAll())
            return View(_mapper.Map<List<CertificationGetDto>>(certification));
        }
    }
}
