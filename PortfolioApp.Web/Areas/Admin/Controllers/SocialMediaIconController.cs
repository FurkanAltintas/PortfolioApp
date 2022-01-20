using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Business.Interfaces;
using PortfolioApp.DTO.DTOs.SocialMediaIconDtos;
using PortfolioApp.Entities.Concrete;
using PortfolioApp.Web.Areas.Admin.Models;
using PortfolioApp.Web.Utils;
using System.Collections.Generic;

namespace PortfolioApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SocialMediaIconController : BaseController
    {
        private readonly ISocialMediaIconService _socialMediaIconService;
        private readonly IGenericService<SocialMediaIcon> _socialMediaIconGenericService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public SocialMediaIconController(ISocialMediaIconService socialMediaIconService, IGenericService<SocialMediaIcon> socialMediaIconGenericService, IUserService userService, IMapper mapper) : base(userService)
        {
            _socialMediaIconService = socialMediaIconService;
            _socialMediaIconGenericService = socialMediaIconGenericService;
            _userService = userService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var model = new SocialMediaIconViewModel
            {
                SocialMediaIcons = _mapper.Map<List<SocialMediaIconListDto>>(_socialMediaIconService.GetById(Id))
            };

            return View(model);
        }

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(SocialMediaIconAddDto socialMediaIconAddDto)
        {
            if (ModelState.IsValid)
            {
                socialMediaIconAddDto.UserId = Id;
                var socialMediaIcon = _mapper.Map<SocialMediaIcon>(socialMediaIconAddDto);
                _socialMediaIconGenericService.Insert(socialMediaIcon);
                return RedirectToAction("Index");
            }

            return View(socialMediaIconAddDto);
        }

        public IActionResult Edit(int id)
        {
            return View(_mapper.Map<SocialMediaIconUpdateDto>(_socialMediaIconGenericService.GetById(id)));
        }

        [HttpPost]
        public IActionResult Edit(SocialMediaIconUpdateDto socialMediaIconUpdateDto)
        {
            if (ModelState.IsValid)
            {
                socialMediaIconUpdateDto.UserId = Id;
                var socialMediaIcon = _mapper.Map<SocialMediaIcon>(socialMediaIconUpdateDto);
                _socialMediaIconGenericService.Update(socialMediaIcon);
                return RedirectToAction("Index");
            }

            return View(socialMediaIconUpdateDto);
        }
    }
}
