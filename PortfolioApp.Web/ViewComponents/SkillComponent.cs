using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Business.Interfaces;
using PortfolioApp.DTO.DTOs.SkillDtos;
using PortfolioApp.Entities.Concrete;
using System.Collections.Generic;

namespace PortfolioApp.Web.ViewComponents
{
    public class SkillComponent : ViewComponent
    {
        private readonly ISkillService _skillService;
        private readonly IMapper _mapper;

        public SkillComponent(ISkillService skillService, IMapper mapper)
        {
            _skillService = skillService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var skillCategory = _skillService.JoinCategory();
          
            // _mapper.Map<List<SkillListDto>>(_skillService.GetAll())
            return View(_mapper.Map<List<SkillGetCategoryListDto>>(skillCategory));
        }
    }
}
