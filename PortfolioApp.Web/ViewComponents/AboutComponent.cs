using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Business.Interfaces;
using PortfolioApp.DTO.DTOs.UserDtos;

namespace PortfolioApp.Web.ViewComponents
{
    public class AboutComponent : ViewComponent
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public AboutComponent(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var user = _mapper.Map<UserListDto>(_userService.GetUser());
            return View(user);
        }
    }
}
